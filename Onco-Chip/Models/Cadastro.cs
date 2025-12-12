using System.ComponentModel.DataAnnotations;

namespace Onco_Chip.Models

{
    public class Cadastro
    {
        public int CadastroId { get; set; }
        // 1. Nome completo
        [Required(ErrorMessage = "O nome completo é obrigatório.")] // Torna o campo obrigatório
        [Display(Name = "Nome completo")] // Define o texto que o 'asp-for' usará na View
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string? NomeCompleto { get; set; }

        // 2. E-mail
        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")] // Valida se é um formato de e-mail
        public string? Email { get; set; }

        // 3. Telefone
        [Display(Name = "Telefone")]
        // Exemplo de Regex (Máscara opcional para telefones brasileiros)
        [RegularExpression(@"^\(?([0-9]{2})\)?([0-9]{4,5})[-. ]?([0-9]{4})$", ErrorMessage = "Telefone inválido.")]
        public string? Telefone { get; set; }

        // 4. CPF
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato do CPF deve ser 000.000.000-00")]
        public string? CPF { get; set; }

        // 5. Endereço
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        // 6. Cidade
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        // 7. CEP
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Formato do CEP deve ser 00000-000")]
        public string? CEP { get; set; }
    }
}