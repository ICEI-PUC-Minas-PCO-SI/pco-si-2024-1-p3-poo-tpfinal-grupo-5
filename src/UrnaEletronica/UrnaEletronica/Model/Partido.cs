using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class PartidoModel
    {
        public int id_Partido { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public int id_coligacao { get; set; }
    }
}
