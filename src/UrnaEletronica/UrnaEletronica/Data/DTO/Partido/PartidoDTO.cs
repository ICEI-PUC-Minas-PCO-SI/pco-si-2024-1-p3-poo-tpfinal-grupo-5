using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DTO.Partido
{
    class PartidoDTO
    {
        public int id_Partido { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public int id_coligacao { get; set; }
        public List<CandidatoModel> Candidatos { get; set; }
    }
}
