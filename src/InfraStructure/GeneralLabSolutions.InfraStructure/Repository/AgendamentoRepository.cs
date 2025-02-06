using System.Linq.Expressions;
using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Interfaces;
using GeneralLabSolutions.InfraStructure.Data;
using GeneralLabSolutions.InfraStructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace GeneralLabSolutions.InfraStructure.Repository
{
    public class AgendamentoRepository : GenericRepository<Agendamento, Guid>, IAgendamentoRepository
    {
        public AgendamentoRepository(AppDbContext context) : base(context){}

        public async Task<IEnumerable<Agendamento>> BuscaSemNoTraking(Expression<Func<Agendamento, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return await _context.Set<Agendamento>()
                    .ToListAsync();
            }
            return await _context.Set<Agendamento>()
                .Where(predicate).ToListAsync();
        }

    }
}
