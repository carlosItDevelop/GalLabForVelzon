using System.ComponentModel.DataAnnotations;

namespace GeneralLabSolutions.Identidade.Dtos
{
    public class CriarRoleDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; } = string.Empty; // Nome da nova role
    }
}