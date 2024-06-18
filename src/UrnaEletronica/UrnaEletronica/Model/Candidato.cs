using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Candidato
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public Partido Partido { get; set; }

        public Candidato(int numero, string nome, Partido partido) 
        { 
            Numero = numero;
            Nome = nome;
            Partido = partido;
        }
    }
}
