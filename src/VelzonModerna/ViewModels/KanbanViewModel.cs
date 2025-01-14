using System;
using System.Collections.Generic;
using GeneralLabSolutions.Domain.Enums;

namespace VelzonModerna.ViewModels
{
    public class KanbanViewModel
    {
        public List<MembroEquipeViewModel> Membros { get; set; } = new List<MembroEquipeViewModel>();
        public List<ListaTarefasViewModel> ListasTarefas { get; set; } = new List<ListaTarefasViewModel>();
    }

    public class MembroEquipeViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        // ... outros campos relevantes para a view, como email, foto, etc. 
    }

    public class ListaTarefasViewModel
    {
        public string Titulo { get; set; } // Ex: "To Do", "Doing", "Done"
        public List<TarefaKanbanViewModel> Tarefas { get; set; } = new List<TarefaKanbanViewModel>();
    }

    public class TarefaKanbanViewModel
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; } // Corresponde ao título da ListaTarefasViewModel onde a tarefa está
        public List<Guid> MembrosIds { get; set; } = new List<Guid>(); // IDs dos membros associados à tarefa
    }
}