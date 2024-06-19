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
    public class Candidato
    {
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }

        public Candidato(string numero, string nome, string partido)
        {
            Numero = numero;
            Nome = nome;
            Partido = partido;
        }

        public Candidato()
        {
        }

        private List<Candidato> candidatos;

        public List<Candidato> GetCandidatos()
        {
            return this.candidatos;
        }

        public void Adicionar(Candidato candidato)
        {
            if (this.candidatos.Exists(c => c.Nome.Equals(candidato.Nome)))
            {
                throw new Exception("Já existe esse candidato");
            }
            else
            {
                this.candidatos.Add(candidato);
            }
        }

        public void Remover(Candidato candidato)
        {
            candidatos.Remove(candidato);
        }

        public void Salvar()
        {
            File.Delete("C://temp//Candidatos.xml");
            XmlSerializer ser = new XmlSerializer(typeof(List<Candidato>));
            FileStream fs = new FileStream("C://temp//Candidatos.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this.candidatos);
            fs.Close();
        }

        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Candidato>));
            FileStream fs = new FileStream("C://temp//Candidatos.xml", FileMode.OpenOrCreate);

            try
            {
                this.candidatos = ser.Deserialize(fs) as List<Candidato>;
            }
            catch (InvalidOperationException ex)
            {
                ser.Serialize(fs, this.candidatos);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
