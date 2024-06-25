using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    internal class VotosCandidatoModel
    {
        public int id_candidato { get; set; }
        public int numero { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public string cargo { get; set; }
        public int quandidade_votos { get; set; }

    }
}
