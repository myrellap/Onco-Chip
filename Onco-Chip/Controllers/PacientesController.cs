using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Onco_Chip.Data;
using Onco_Chip.Models;

namespace OncoChipApp.Controllers
{
    public class PacienteController : Controller
    {
        // GET: /Paciente/
        public IActionResult Index()
        {
            var vm = MontarPaciente();
            return View(vm);
        }

        // GET: /Paciente/Controle
        public IActionResult Controle()
        {
            var vm = MontarPaciente();
            return View(vm);
        }

        // Ação de exemplo para "Exportar PDF" (stub - retorna texto como arquivo)
        public IActionResult ExportarRelatorio(string id)
        {
            var content = $"Relatório do paciente {id} gerado em {DateTime.Now}";
            var bytes = System.Text.Encoding.UTF8.GetBytes(content);
            return File(bytes, "application/octet-stream", $"Relatorio_{id}.txt");
        }

        private PacienteViewModel MontarPaciente()
        {
            return new PacienteViewModel
            {
                Nome = "João da Silva",
                Id = "289877",
                Idade = 58,
                ChipStatus = "Operacional",
                BateriaPercent = 85,
                Temperatura = "36°C",
                UltimaSincronizacao = DateTime.Today.AddHours(-2),
                ProgressoTratamentoPercent = 65,
                RespostaCelulas = new List<int> { 80, 70, 65, 60, 55, 45 }, // Jan..Jun
                MensagemComunicacao = "Sua próxima consulta está marcada para o dia 01/12, às 15h.",
                Observacoes = "Paciente com monitoramento remoto ativo."
            };
        }
    }
}




