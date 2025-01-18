// NovaTarefaDto.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VelzonModerna.ViewModels
{
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