using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DTO.Eleicao
{
    internal class EleicaoDTO
    {
        public int id_eleicao { get; set; }
        public int ano { get; set; }
        public string tipo { get; set; }
        public int total_votos { get; set; }
        public List<ColigacaoModel> Coligacaos { get; set; }
    }
}
