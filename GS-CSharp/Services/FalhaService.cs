using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS_CSharp.Models;

namespace GS_CSharp.Services
{
    public class FalhaService
    {
        private static Relatorio relatorio = new Relatorio();

        public void RegistrarFalha()
        {
            try
            {
                Console.Write("Sistema afetado: ");
                string sistema = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(sistema))
                    throw new ArgumentException("O nome do sistema não pode estar vazio.");

                Console.Write("Descrição da falha: ");
                string descricao = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(descricao))
                    throw new ArgumentException("A descrição não pode estar vazia.");

                Falha falha = new Falha(sistema, descricao);
                relatorio.AdicionarFalha(falha);

                Console.WriteLine("Falha registrada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}");
            }
        }

        public Relatorio ObterRelatorio()
        {
            return relatorio;
        }
    }
}
