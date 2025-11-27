using System.ComponentModel.DataAnnotations;

namespace Onco_Chip.Models
{
    public class Contato
    {
        [Key]
        public int ContatoId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [StringLength(20)]
        [Phone(ErrorMessage = "Telefone inválido.")]
        public string Telefone { get; set; }

        [StringLength(200)]
        public string Endereco { get; set; }

        [StringLength(500)]
        public string? Observacao { get; set; }   // Campo opcional

        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}

