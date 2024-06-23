using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DAO.Eleicao
{
    static class EleicaoDAO
    {
        public static EleicaoModel BuscarEleicao(int ano, string tipo)
        {
            EleicaoModel eleicao = new EleicaoModel();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM eleicao WHERE ano = @ano and tipo = @tipo;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ano", ano);
                    command.Parameters.AddWithValue("@tipo", tipo);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            eleicao.id_eleicao = reader.GetInt32("id_eleicao");
                            eleicao.ano = reader.GetInt32("id_coligacao");
                            eleicao.tipo = reader.GetString("tipo");
                            eleicao.total_votos = reader.GetInt32("total_votos");
                        }
                    }
                }
            }

            return eleicao;
        }

        public static List<EleicaoModel> BuscarListaEleicao()
        {
            List<EleicaoModel> eleicaoList = new List<EleicaoModel>();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM eleicao";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EleicaoModel eleicao = new EleicaoModel() {
                                id_eleicao = reader.GetInt32("id_eleicao"),
                                ano = reader.GetInt32("ano"),
                                tipo = reader.GetString("tipo"),
                                total_votos = reader.GetInt32("total_votos")
                            };

                            eleicaoList.Add(eleicao);
                        }
                    }
                }
            }

            return eleicaoList;
        }

        public static void CadastrarEleicao(int ano, string tipo, int total_votos)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Eleicao (ano, tipo, total_votos) VALUES (@ano, @tipo, @total_votos)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ano", ano);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@total_votos", total_votos);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AtualizarEleicao(EleicaoModel e)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "UPDATE candidato SET ano = @ano, tipo = @tipo, total_votos = @total_votos WHERE id_eleicao = @idEleicao;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ano", e.ano);
                    command.Parameters.AddWithValue("@tipo", e.tipo);
                    command.Parameters.AddWithValue("@total_votos", e.total_votos);
                    command.Parameters.AddWithValue("@id_eleicao", e.id_eleicao);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeletarEleicao(int idEleicao)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM Eleicao WHERE id_eleicao = @idEleicao";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idEleicao", idEleicao);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
