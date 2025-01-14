using GeneralLabSolutions.WebAPI.DTOs;
using GeneralLabSolutions.Domain.Extensions.Helpers.Generics;
using mamix.Services.Base;
using System.Net.Http.Json;
using System.Net.Http;

namespace mamix.Services.Produtos
{
    public interface IProdutoService
    {
        Task<PagedResult<ProdutoGridDto>> ObterProdutosPaginadosAsync(int pageIndex, int pageSize, string? query = null);
    }

    public class ProdutoService : BaseService<ProdutoGridDto>, IProdutoService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProdutoService(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory, "api/produto")
        { 
            _httpClientFactory = httpClientFactory;
        }


        public async Task<PagedResult<ProdutoGridDto>> ObterProdutosPaginadosAsync(int pageIndex, int pageSize, string? query = null)
        {
            var client = _httpClientFactory.CreateClient("CadastroApi");
            var url = $"api/produto/produtos-paginados?pageIndex={pageIndex}&pageSize={pageSize}";

            if (!string.IsNullOrWhiteSpace(query))
            {
                url += $"&query={query}";
            }

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<PagedResult<ProdutoGridDto>>();
            return result ?? new PagedResult<ProdutoGridDto>
            {
                List = Enumerable.Empty<ProdutoGridDto>(),
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }
    }
}
