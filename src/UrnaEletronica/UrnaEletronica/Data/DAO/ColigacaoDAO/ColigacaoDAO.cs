using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DAO.Coligacao
{
    internal class ColigacaoDAO
    {
        public ColigacaoModel BuscarColigacao(int idColigacao)
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

        public List<ColigacaoModel> BuscarColigacao()
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

        public void CadastrarColigacao(string nomeColigacao)
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

        public void AtualizarColigacao(int idColigacao, string nomeColigacao)
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

        public void DeletarColigacao(int idColigacao)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM coligacao WHERE id_coligacao = @idColigacao";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idColigacao", idColigacao);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
