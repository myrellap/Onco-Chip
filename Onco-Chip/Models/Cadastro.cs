using System.ComponentModel.DataAnnotations;

namespace Onco_Chip.Models
{
    public class Cadastro
    {
        [Key]
        public int CadastroId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone inválido.")]
        public string Telefone { get; set; }
    }
}
