using GeneralLabSolutions.WebAPI.DTOs;
using mamix.Services.Base;

namespace mamix.Services.Vendedores
{

    public interface IVendedorService
    {
        Task<IEnumerable<VendedorGridDto>> ObterVendedoresAsync();
    }

    public class VendedorService : BaseService<VendedorGridDto>, IVendedorService
    {
        public VendedorService(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory, "api/vendedor")
        { }

        public async Task<IEnumerable<VendedorGridDto>> ObterVendedoresAsync()
        {
            return await GetAsync("lista-vendedores");
        }
    }

}
