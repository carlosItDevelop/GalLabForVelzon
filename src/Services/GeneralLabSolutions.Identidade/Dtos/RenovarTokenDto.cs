using System.ComponentModel.DataAnnotations;

namespace GeneralLabSolutions.Identidade.Dtos
{
    public class RenovarTokenDto
    {
        [Required(ErrorMessage = "O RefreshToken é obrigatório")]
        public string RefreshToken { get; set; }
    }
}
