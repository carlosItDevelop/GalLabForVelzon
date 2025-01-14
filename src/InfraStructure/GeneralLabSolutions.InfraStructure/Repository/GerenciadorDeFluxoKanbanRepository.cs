using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Interfaces;
using GeneralLabSolutions.InfraStructure.Data;
using GeneralLabSolutions.InfraStructure.Repository.Base;
using System;
using System.Threading.Tasks;

namespace GeneralLabSolutions.InfraStructure.Repository
{
    public class GerenciadorDeFluxoKanbanRepository 
        : GenericRepository<GerenciadorDeFluxoKanban, Guid>,
        IGerenciadorDeFluxoKanbanRepository
    {

        private readonly IQueryGenericRepository<GerenciadorDeFluxoKanban, Guid> _queryRepository;

        public GerenciadorDeFluxoKanbanRepository(AppDbContext context, IQueryGenericRepository<GerenciadorDeFluxoKanban, Guid> queryRepository) : base(context)
        {
            _queryRepository = queryRepository;
        }

        // Implementação de métodos específicos, se necessário
    }
}