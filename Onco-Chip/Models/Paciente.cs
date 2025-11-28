namespace Onco_Chip.Models
{
    public class App
    {
        public string? Nome { get; set; }
        public string? Id { get; set; }
        public int Idade { get; set; }

        // CHIP info
        public string? ChipStatus { get; set; } // "Operacional", etc.
        public int BateriaPercent { get; set; } // ex: 85
        public string? Temperatura { get; set; } // ex: "36°C"
        public DateTime UltimaSincronizacao { get; set; }

        // Tratamento
        public int ProgressoTratamentoPercent { get; set; } // ex: 65

        // Grafico - resposta das células ao tratamento (meses)
        public List<int> RespostaCelulas { get; set; } = new List<int>();

        // Mensagens/comunicacao
        public string? MensagemComunicacao { get; set; }

        // Acoes rapidas
        public bool PermiteAjustarDosagem { get; set; } = true;
        public bool PermiteSolicitarExames { get; set; } = true;

        // Outros (exemplos)
        public string? Observacoes { get; set; }
    }
}



