using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Service
{
    public static class JsonDatabaseService
    {
        public static void gravaArquivo()
        {
            //string Json = "";
            //Json = JsonConvert.SerializeObject(usu);

            //File.WriteAllText(caminho.geraCaminho(), Json);
        }
        public static string geraCaminho(string arquivo)
        {
            //mudado o endereço da pasta do json
            string caminhoArquivo = "Banco\\Usuarios.json";
            string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, caminhoArquivo);

            return caminhoCompleto;
        }
    }
}
