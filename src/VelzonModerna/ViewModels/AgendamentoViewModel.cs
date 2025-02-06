using GeneralLabSolutions.Domain.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace VelzonModerna.ViewModels
{
    public class AgendamentoViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Título obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Data Inválida")]
        [Display(Name = "Data do Evento")]
        [DataType(DataType.Date)] // Adicionado DataType.Date
        public DateTime DataEvento { get; set; } // <=== Nova propriedade para a data

        [Display(Name = "Hora de Início")]
        [DataType(DataType.Time)] // Adicionado DataType.Time
        public TimeSpan? HoraInicio { get; set; } // <=== Nova propriedade para a hora de início

        [Display(Name = "Hora de Fim")]
        [DataType(DataType.Time)] // Adicionado DataType.Time
        public TimeSpan? HoraFim { get; set; } // <=== Nova propriedade para a hora de fim


        [BindNever] // Impede o Model Binding direto desta propriedade
        public DateTime DataInicio { get; set; } // Propriedade combinada (Data + Hora)

        [BindNever] // Impede o Model Binding direto desta propriedade
        public DateTime? DataFim { get; set; } // Propriedade combinada (Data + Hora)


        [StringLength(150, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Localização")]
        public string Localizacao { get; set; }


        [StringLength(600, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Tipo do Evento")]
        public TipoEvento TipoEvento { get; set; }

        [Display(Name = "Dia Todo")]
        public bool DiaTodo { get; set; }
    }
}