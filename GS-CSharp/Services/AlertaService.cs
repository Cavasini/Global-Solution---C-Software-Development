using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS_CSharp.Models;

namespace GS_CSharp.Services
{
    public class AlertaService
    {
        private static Relatorio relatorio = new Relatorio();

        public void GerarAlerta()
        {
            try
            {
                Console.Write("Mensagem do alerta: ");
                string mensagem = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(mensagem))
                    throw new ArgumentException("A mensagem do alerta não pode estar vazia.");

                Console.Write("Nível (Baixo / Médio / Alto): ");
                string nivel = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nivel))
                    throw new ArgumentException("O nível do alerta não pode estar vazio.");

                Alerta alerta = new Alerta(mensagem, nivel);
                relatorio.AdicionarAlerta(alerta);

                Console.WriteLine("Alerta gerado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar alerta: {ex.Message}");
            }
        }

        public Relatorio ObterRelatorio()
        {
            return relatorio;
        }
    }
}
