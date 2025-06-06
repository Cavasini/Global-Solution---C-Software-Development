using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_CSharp.Models
{
    public class Alerta
    {
        public string Mensagem { get; set; }
        public string Nivel { get; set; }
        public DateTime DataHora { get; set; }

        public Alerta(string mensagem, string nivel)
        {
            Mensagem = mensagem;
            Nivel = nivel;
            DataHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{DataHora:G} | Nível: {Nivel} | Mensagem: {Mensagem}";
        }
    }
}
