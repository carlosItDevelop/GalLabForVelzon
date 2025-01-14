using System.Net.Http;
using GeneralLabSolutions.Domain.Extensions.Helpers.Generics;
using GeneralLabSolutions.WebAPI.DTOs;
using mamix.Services.Base;

namespace mamix.Services.Clientes
{

    public interface IClienteService
    {
        // Novo método para buscar dados paginados:
        Task<PagedResult<ClienteGridDto>> ObterClientesPaginadosAsync(int pageIndex, int pageSize, string? query = null);
    }

    public class ClienteService : BaseService<ClienteGridDto>, IClienteService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ClienteService(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory, "api/cliente")
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<PagedResult<ClienteGridDto>> ObterClientesPaginadosAsync(int pageIndex, int pageSize, string? query = null)
        {
            var client = _httpClientFactory.CreateClient("CadastroApi");

            var url = $"api/cliente/lista-clientes-paginados?pageIndex={pageIndex}&pageSize={pageSize}";
            if (!string.IsNullOrEmpty(query))
            {
                url += $"&query={query}";
            }

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Aqui assumimos que a API já retorna um JSON no formato de um PagedResult<ClienteGridDto>
            var result = await response.Content.ReadFromJsonAsync<PagedResult<ClienteGridDto>>();
            return result ?? new PagedResult<ClienteGridDto>
            {
                List = Enumerable.Empty<ClienteGridDto>(),
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }
    }

}
