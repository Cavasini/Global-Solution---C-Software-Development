using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_CSharp.Services
{
    public class RelatorioService
    {
        private readonly FalhaService falhaService = new FalhaService();
        private readonly AlertaService alertaService = new AlertaService();

        public void ExibirRelatorioCompleto()
        {
            var relatorioFalhas = falhaService.ObterRelatorio();
            var relatorioAlertas = alertaService.ObterRelatorio();

            Console.WriteLine("\n===== RELATÓRIO DE FALHAS =====");
            if (relatorioFalhas.Falhas.Count == 0)
                Console.WriteLine("Nenhuma falha registrada.");
            else
                relatorioFalhas.Falhas.ForEach(f => Console.WriteLine(f.ToString()));

            Console.WriteLine("\n===== RELATÓRIO DE ALERTAS =====");
            if (relatorioAlertas.Alertas.Count == 0)
                Console.WriteLine("Nenhum alerta gerado.");
            else
                relatorioAlertas.Alertas.ForEach(a => Console.WriteLine(a.ToString()));

        }
    }
}
