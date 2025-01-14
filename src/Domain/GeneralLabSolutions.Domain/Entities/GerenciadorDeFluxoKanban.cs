using GeneralLabSolutions.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeneralLabSolutions.Domain.Entities
{
    [Table("GerenciadorDeFluxoKanban")]
    public class GerenciadorDeFluxoKanban : EntityBase
    {
        public GerenciadorDeFluxoKanban(string titulo,
                                        string descricao,
                                        string status,
                                        DateTime dataVencimento)
        {
            Titulo = titulo;
            Descricao = descricao;
            Status = status;
            DataVencimento = dataVencimento;
        }

        // EF
        public GerenciadorDeFluxoKanban() { }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Titulo { get; private set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; private set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Status { get; private set; } = string.Empty;

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataVencimento { get; private set; }


        public virtual ICollection<MembroEquipe> Membros { get; set; } = new List<MembroEquipe>();


        // Métodos para atualizar as propriedades (setters privados)
        public void AtualizarTitulo(string titulo)
        {
            Titulo = titulo;
        }

        public void AtualizarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void AtualizarStatus(string status)
        {
            Status = status;
        }

        public void AtualizarDataVencimento(DateTime dataVencimento)
        {
            DataVencimento = dataVencimento;
        }
    }
}