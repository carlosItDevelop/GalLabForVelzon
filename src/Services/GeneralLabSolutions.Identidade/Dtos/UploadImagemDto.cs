using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GeneralLabSolutions.Identidade.Dtos
{
    public class UploadImagemDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string UserId { get; set; } = string.Empty; // ID do usuário

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public IFormFile Imagem { get; set; } = null!;
    }
}