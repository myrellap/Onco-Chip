namespace Onco_Chip.Models
{
    public class Paciente
    {
        public string? Nome { get; set; }
        public string? Id { get; set; }
        public int Idade { get; set; }

        public string? ChipStatus { get; set; }
        public int BateriaPercent { get; set; } // ex: 85
        public string? Temperatura { get; set; } // ex: "36°C"
        public DateTime UltimaSincronizacao { get; set; }


        public int ProgressoTratamentoPercent { get; set; }


        public List<int> RespostaCelulas { get; set; } = new List<int>();


        public string? MensagemComunicacao { get; set; }


        public bool PermiteAjustarDosagem { get; set; } = true;
        public bool PermiteSolicitarExames { get; set; } = true;


        public string? Observacoes { get; set; }

    }
}