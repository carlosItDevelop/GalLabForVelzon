using GeneralLabSolutions.WebAPI.DTOs;
using mamix.Services.Base;

namespace mamix.Services.Categorias
{

    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaProdutoDto>> ObterCategoriasAsync();
    }

    public class CategoriaService : BaseService<CategoriaProdutoDto>, ICategoriaService
    {
        public CategoriaService(IHttpClientFactory httpClientFactory) 
            : base(httpClientFactory, "api/categoria")
        {}

        public async Task<IEnumerable<CategoriaProdutoDto>> ObterCategoriasAsync()
        {
            return await GetAsync("lista-categorias");
        }
    }
}
