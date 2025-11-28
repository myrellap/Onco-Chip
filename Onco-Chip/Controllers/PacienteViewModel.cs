
namespace OncoChipApp.Controllers
{
    internal class PacienteViewModel
    {
        public string Nome { get; set; }
        public string Id { get; set; }
        public int Idade { get; set; }
        public string ChipStatus { get; set; }
        public int BateriaPercent { get; set; }
        public string Temperatura { get; set; }
        public DateTime UltimaSincronizacao { get; set; }
        public int ProgressoTratamentoPercent { get; set; }
        public List<int> RespostaCelulas { get; set; }
        public string MensagemComunicacao { get; set; }
        public string Observacoes { get; set; }
    }
}