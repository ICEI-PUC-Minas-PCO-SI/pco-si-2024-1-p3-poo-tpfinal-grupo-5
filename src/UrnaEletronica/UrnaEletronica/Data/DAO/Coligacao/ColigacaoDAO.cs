using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DAO.Coligacao
{
    static class ColigacaoDAO
    {
        public static ColigacaoModel BuscarColigacao(int idColigacao)
        {
            ColigacaoModel coligacao = new ColigacaoModel();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM coligacao WHERE id_coligacao = @idColigacao";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idColigacao", idColigacao);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            coligacao.IdColigacao = reader.GetInt32("id_coligacao");
                            coligacao.Nome = reader.GetString("nome");
                        }
                    }
                }
            }

            return coligacao;
        }

<<<<<<< HEAD
        public static List<ColigacaoModel> BuscarListaColigacao()
=======
        public static List<ColigacaoModel> BuscarColigacao()
>>>>>>> origin/CrudHigor
        {
            List<ColigacaoModel> coligacoes = new List<ColigacaoModel>();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM coligacao";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ColigacaoModel coligacao = new ColigacaoModel();
                            coligacao.IdColigacao = reader.GetInt32("id_coligacao");
                            coligacao.Nome = reader.GetString("nome");

                            coligacoes.Add(coligacao);
                        }
                    }
                }
            }

            return coligacoes;
        }

        public static void CadastrarColigacao(string nomeColigacao)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO coligacao (nome) VALUES (@nomeColigacao)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomeColigacao", nomeColigacao);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AtualizarColigacao(int idColigacao, string nomeColigacao)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "UPDATE coligacao SET nome = @nomeColigacao WHERE id_coligacao = @idColigacao";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idColigacao", idColigacao);
                    command.Parameters.AddWithValue("@nomeColigacao", nomeColigacao);

                    command.ExecuteNonQuery();
                }
            }
        }

<<<<<<< HEAD
        public static void DeletarColigacao(string nome)
=======
        public static void DeletarColigacao(int idColigacao)
>>>>>>> origin/CrudHigor
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM coligacao WHERE nome = @nome";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nome);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
