using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onco_Chip.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string NomeCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Senha { get; set; }

        [Required]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem")]
        public string? ConfirmarSenha { get; set; }

    }
}
