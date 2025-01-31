using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralLabSolutions.Domain.Entities.Base;

namespace GeneralLabSolutions.Domain.Entities
{
    public enum ActionType
    {
        Create,
        Delete,
        Update,
        Move
    }

    public class UndoRedoAction : EntityBase
    {
        public ActionType ActionType { get; set; }

        // Armazenamos o estado anterior da task em JSON, se houver
        public string? BeforeData { get; set; }

        // Armazenamos o estado final da task em JSON, se houver
        public string? AfterData { get; set; }

        // Poderíamos registrar quando ocorreu
        public DateTime ActionDate { get; set; } = DateTime.UtcNow;
    }
}
