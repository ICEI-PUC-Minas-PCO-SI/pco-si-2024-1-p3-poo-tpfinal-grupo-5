using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UrnaEletronica.Model
{
    public class CandidatoModel
    {
        public int IdCandidato { get; set; }
        public string nome { get; set; }
        public int id_partido { get; set; }
        public string apelido { get; set; }
    }
}
