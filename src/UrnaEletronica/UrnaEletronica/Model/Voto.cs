using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Voto
    {
        public string Tipo {  get; set; }
        public Candidato Candidato { get; set; }

        public Voto(string tipo, Candidato candidato)
        {
            Tipo = tipo;
            Candidato = candidato;
        }
    }
}
