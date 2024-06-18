using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Candidato
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nome {  get; set; }
        public string Partido { get; set; }
    }
}
