using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DAO.Partido
{
    static class  PartidoDAO
    {
        public static PartidoModel BuscarPartido (int idPartido)
        {
            PartidoModel partido = new PartidoModel();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM partido WHERE id_partido = @idPartido";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPartido", idPartido);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            partido.id_Partido = reader.GetInt32("id_partido");
                            partido.nome = reader.GetString("nome");
                            partido.sigla = reader.GetString("nome");
                            partido.id_coligacao = reader.GetInt32("id_coligacao");
                        }
                    }
                }
            }

            return partido;
        }

        public static List<PartidoModel> BuscarPartidoLista()
        {
            List<PartidoModel> partidoList = new List<PartidoModel>();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM partido";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PartidoModel partido = new PartidoModel();
                            partido.id_Partido = reader.GetInt32("id_partido");
                            partido.nome = reader.GetString("nome");
                            partido.sigla = reader.GetString("sigla");
                            partido.id_coligacao = reader.GetInt32("id_coligacao");

                            partidoList.Add(partido);
                        }
                    }
                }
            }

            return partidoList;
        }

        public static void CadastrarPartido(PartidoModel p)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO partido (id_partido,nome, sigla, id_coligacao) VALUES (@id_partido,@nome, @sigla, @id_coligacao)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_partido", p.id_Partido);
                    command.Parameters.AddWithValue("@nome", p.nome);
                    command.Parameters.AddWithValue("@sigla", p.sigla);
                    command.Parameters.AddWithValue("@id_coligacao", p.id_coligacao);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AtualizarPartido(string nome, string sigla, int id_coligacao, int idPartido)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "UPDATE partido SET nome = @nome, sigla = @sigla, id_coligacao = @id_coligacao WHERE id_partido = @idPartido;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@sigla", sigla);
                    command.Parameters.AddWithValue("@id_coligacao", id_coligacao);
                    command.Parameters.AddWithValue("@idPartido", idPartido);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeletarPartido(int idPartido)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM partido WHERE id_partido = @idPartido";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPartido", idPartido);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
