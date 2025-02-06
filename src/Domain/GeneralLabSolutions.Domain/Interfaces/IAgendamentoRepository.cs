using System.Linq.Expressions;
using GeneralLabSolutions.Domain.Entities;

namespace GeneralLabSolutions.Domain.Interfaces
{
    public interface IAgendamentoRepository : IGenericRepository<Agendamento, Guid>
    {
        Task<IEnumerable<Agendamento>> BuscaSemNoTraking(Expression<Func<Agendamento, bool>> predicate = null);

    }
}
