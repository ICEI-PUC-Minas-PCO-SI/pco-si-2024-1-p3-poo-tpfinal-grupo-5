using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Eleicao
    {
        private string nome;
        private int ano;
        private string tipo;
        private List<Coligacao> Coligacaos;
        private List<Partido> Partidos;
        private int totalVotosValidos;
        private int totalVotosNulos;
    }
}
