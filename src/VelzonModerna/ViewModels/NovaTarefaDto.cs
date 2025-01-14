// NovaTarefaDto.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GeneralLabSolutions.Domain.Extensions.Helpers.Dtos.Dtoskanban
{
    //public class NovaTarefaDto
    //{
    //    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    //    [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    //    public string titulo { get; set; } = string.Empty;

    //    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    //    [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    //    public string descricao { get; set; } = string.Empty;

    //    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    //    [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
    //    public DateTime dataVencimento { get; set; }

    //    public string status { get; set; } = string.Empty;
    //}


    public class NovaTarefaDto
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("dataVencimento")]
        public DateTime DataVencimento { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }


}