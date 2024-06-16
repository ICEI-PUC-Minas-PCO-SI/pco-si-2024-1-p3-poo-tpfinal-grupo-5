using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UrnaEletronica.Service
{
    public static class JsonDatabaseService
    {
        public static List<object> lerArquivo(string entidadeBanco)
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

            

        }

        public static string geraCaminho(string entidadeBanco)
        {
            string caminhoArquivo = $"Banco\\{entidadeBanco}.json";
            string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, caminhoArquivo);

            return caminhoCompleto;
        }

    }
}
