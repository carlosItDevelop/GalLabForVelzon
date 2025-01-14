using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Extensions.Helpers.Dtos.DtosConsolidados;

namespace GeneralLabSolutions.Domain.Interfaces
{
    public interface IConsolidadoFornecedorRepository
    {
        Task<FornecedorConsolidadoDto?> ObterConsolidadoFornecedorPorIdAsync(Guid fornecedorId);
        Task<IEnumerable<Fornecedor>> ObterTodosFornecedoresAsync();
    }
}