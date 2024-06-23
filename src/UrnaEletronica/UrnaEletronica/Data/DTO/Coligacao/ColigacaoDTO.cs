using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DTO.Coligacao
{
    class ColigacaoDTO
    {
        public int IdColigacao { get; set; }
        public string Nome { get; set; }
        public List<PartidoModel> Partidos  {  get; set; }
    }
}
