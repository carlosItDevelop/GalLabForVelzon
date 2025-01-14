using GeneralLabSolutions.Domain.Entities;

namespace GeneralLabSolutions.Domain.Interfaces
{
    public interface IGerenciadorDeFluxoKanbanRepository : IGenericRepository<GerenciadorDeFluxoKanban, Guid>
    {
        // Outros métodos específicos para o Kanban podem ser adicionados aqui, se necessário
    }
}