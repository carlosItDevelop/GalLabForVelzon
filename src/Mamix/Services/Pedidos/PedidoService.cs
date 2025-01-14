using GeneralLabSolutions.WebAPI.DTOs;
using mamix.Services.Base;


namespace mamix.Services.Pedidos
{
    public interface IPedidoService
    {
        Task<IEnumerable<PedidoGridDto>> ObterPedidosAsync();
    }

    public class PedidoService : BaseService<PedidoGridDto>, IPedidoService
    {
        public PedidoService(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory, "api/pedido")
        { }

        public async Task<IEnumerable<PedidoGridDto>> ObterPedidosAsync()
        {
            return await GetAsync("pedidos");
        }
    }

}