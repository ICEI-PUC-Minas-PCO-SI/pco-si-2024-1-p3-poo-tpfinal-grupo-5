using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using UrnaEletronica.Model;

namespace UrnaEletronica.Service
{
    public class JsonDatabaseService
    {
        private Dictionary<string, Candidato> _dicCandidato;
        /*public static List<object> lerArquivo(string entidadeBanco)
        {
            try
            {
                string json = File.ReadAllText(entidadeBanco);
                //json = SerializeObjectList(myObjectList);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            

        }*/

        public static string geraCaminho(string entidadeBanco)
        {
            string caminhoArquivo = $"Banco\\{entidadeBanco}.json";
            string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, caminhoArquivo);

            return caminhoCompleto;
        }

        public void CarregarCandidatos()
        {
            _dicCandidato = new Dictionary<string, Candidato>();
            string caminho = "C:\\Users\\faelr\\OneDrive\\Documentos\\UrnaPOO\\pco-si-2024-1-p3-poo-tpfinal-grupo-5\\src\\UrnaEletronica\\UrnaEletronica\\JsonFiles\\Presidentes.json";
            if (File.Exists(caminho))
            {
                try
                {
                    string jsonString = File.ReadAllText(caminho);
                    var candidatos = System.Text.Json.JsonSerializer.Deserialize<List<Candidato>>(jsonString);
                    foreach (var candidato in candidatos)
                    {
                        _dicCandidato.Add(candidato.Numero.ToString(), candidato);
                    }
                }
                catch (FileNotFoundException erro)
                {
                    MessageBox.Show("Erro ao carregar o arquivo");
                }

            }
            else
            {
                MessageBox.Show("Arquivo de candidatos não encontrado");
            }
        }

    }
}
