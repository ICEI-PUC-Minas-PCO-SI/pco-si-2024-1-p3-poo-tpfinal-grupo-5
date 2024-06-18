using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class EleicaoLegislativo : Eleicao
    {
        public EleicaoLegislativo(string tipo) : base(tipo)
        {
        }

        public override void CalcularResultado()
        {
        }
    }
}
