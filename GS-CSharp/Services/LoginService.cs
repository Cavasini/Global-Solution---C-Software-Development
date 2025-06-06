using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS_CSharp.Models;

namespace GS_CSharp.Services
{
    public class LoginService
    {
        private readonly Usuario usuarioPadrao = new Usuario("admin", "123");

        public bool Login()
        {
            Console.Write("Usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (nome == usuarioPadrao.Nome && senha == usuarioPadrao.Senha)
            {
                Console.WriteLine("Login realizado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos.");
                return false;
            }
        }
    }
}
