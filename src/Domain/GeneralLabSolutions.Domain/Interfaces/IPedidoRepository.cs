using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Enums;
using GeneralLabSolutions.Domain.Extensions.Helpers.Dtos.DtosGraficos;
using GeneralLabSolutions.Domain.Extensions.Helpers.Dtos.DtosViewComponents;

namespace GeneralLabSolutions.Domain.Interfaces
{
    public interface IPedidoRepository : IGenericRepository<Pedido, Guid>
    {
        Task<IEnumerable<Pedido>> GetAllPedidosWithIncludesAsync();

        Task<PedidoResumoDto> GetQuantidadeEValorTotalPorStatusAsync(StatusDoPedido status);

        Task<Dictionary<StatusDoPedido, List<decimal>>> GetVendasDeJaneiroADezembroDe2024Async();

        Task<List<TopVendedoresDto>> GetTop10VendedoresAsync();

        /* 3º GRÁFICO DAQUI PR BAIXO - Trimestral */

        Task<List<ClientePeriodoDto>> GetTop4ClientesPorPeriodoQuantidadeAsync(int ano, int mesesPorPeriodo);
        Task<List<ClientePeriodoDto>> GetTop4ClientesPorPeriodoValorAsync(int ano, int mesesPorPeriodo);

    }
}
