using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Interfaces;
using GeneralLabSolutions.InfraStructure.Data;
using GeneralLabSolutions.InfraStructure.Repository.Base;

namespace GeneralLabSolutions.InfraStructure.Repository
{
    public class MembroEquipeRepository : GenericRepository<MembroEquipe, Guid>, IMembroEquipeRepository
    {
        public MembroEquipeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
