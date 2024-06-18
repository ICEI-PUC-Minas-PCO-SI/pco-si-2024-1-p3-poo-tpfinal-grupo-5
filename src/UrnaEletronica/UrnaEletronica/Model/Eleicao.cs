using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Eleicao
    {
        public string Tipo {  get; set; }
        public List<Candidato> Candidatos { get; set; }
        public List<Voto> Votos { get; set; }

        public Eleicao(string tipo)
        {
            Tipo = tipo;
            Candidatos = new List<Candidato>();
            Votos = new List<Voto>();
        }

        public void AdicionarCandidato(Candidato candidato)
        {
            Candidatos.Add(candidato);
        }

        public void RegistrarVoto(Voto voto)
        {
            Votos.Add(voto);
        }

        public virtual void CalcularResultado()
        {

        }
    }
}
