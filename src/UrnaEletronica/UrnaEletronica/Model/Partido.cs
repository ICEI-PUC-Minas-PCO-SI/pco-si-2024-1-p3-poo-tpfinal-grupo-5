using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class PartidoModel
    {
        public PartidoModel(int id_Partido, string nome, string sigla, int id_coligacao)
        {
            this.id_Partido = id_Partido;
            this.nome = nome;
            this.sigla = sigla;
            this.id_coligacao = id_coligacao;
        }

        public PartidoModel() { 
        
        }
        public int id_Partido { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public int id_coligacao { get; set; }

       
    }

    

    
}
