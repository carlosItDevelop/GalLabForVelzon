using GeneralLabSolutions.Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeneralLabSolutions.Domain.Entities
{
    [Table("MembroEquipe")]
    public class MembroEquipe : EntityBase
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; } = string.Empty;

        // ... outros campos, como email, foto, cargo, etc.

        // Relacionamento N:N com GerenciadorDeFluxoKanban
        public virtual ICollection<GerenciadorDeFluxoKanban> Tarefas { get; set; } = new List<GerenciadorDeFluxoKanban>();
    }
}