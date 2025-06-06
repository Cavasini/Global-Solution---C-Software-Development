using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_CSharp.Models
{
    public class Falha
    {
        public string SistemaAfetado { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        public Falha(string sistema, string descricao)
        {
            SistemaAfetado = sistema;
            Descricao = descricao;
            Data = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Data:G} | Sistema: {SistemaAfetado} | Falha: {Descricao}";
        }
    }
}
