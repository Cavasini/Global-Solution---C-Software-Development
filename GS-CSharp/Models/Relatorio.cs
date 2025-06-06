using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_CSharp.Models
{
    public class Relatorio
    {
        public List<Falha> Falhas { get; set; } = new List<Falha>();
        public List<Alerta> Alertas { get; set; } = new List<Alerta>();

        public void AdicionarFalha(Falha f) => Falhas.Add(f);
        public void AdicionarAlerta(Alerta a) => Alertas.Add(a);
    }
}
