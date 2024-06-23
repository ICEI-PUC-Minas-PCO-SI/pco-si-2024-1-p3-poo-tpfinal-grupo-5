using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DAO.Candidato
{
    static class CandidatoDAO
    {
        public static CandidatoModel BuscarCandidato(int idCandidato)
        {
            CandidatoModel candidato = new CandidatoModel();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM candidato WHERE numero = @numero";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numero", idCandidato);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            candidato.IdCandidato = reader.GetInt32("id_candidato");
                            candidato.numero = reader.GetInt32("numero");
                            candidato.nome = reader.GetString("nome");
                            candidato.apelido = reader.GetString("apelido");
                            candidato.IdPartido = reader.GetInt32("id_partido");
                        }
                    }
                }
            }

            return candidato;
        }

        public static List<CandidatoModel> BuscarListaCandidato()
        {
            List<CandidatoModel> coligacoes = new List<CandidatoModel>();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT candidato.id_candidato, candidato.numero, candidato.nome, candidato.apelido, partido.id_partido, partido.sigla FROM candidato join partido on candidato.id_partido = partido.id_partido;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CandidatoModel candidato = new CandidatoModel();
                            candidato.IdCandidato= reader.GetInt32("id_candidato");
                            candidato.numero = reader.GetInt32("numero");
                            candidato.nome = reader.GetString("nome");
                            candidato.apelido = reader.GetString("apelido");
                            candidato.IdPartido = reader.GetInt32("id_partido");
                            candidato.partido = reader.GetString("sigla");

                            coligacoes.Add(candidato);
                        }
                    }
                }
            }

            return coligacoes;
        }

        public static void CadastrarCandidato(string nomeCandidato, string apelido, int numero, int idPartido)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO candidato (id_candidato, numero, nome, apelido, id_partido) VALUES (@numero, @numero, @nome, @apelido, @id_partido)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_candidato", numero);
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@nome", nomeCandidato);
                    command.Parameters.AddWithValue("@apelido", apelido);
                    command.Parameters.AddWithValue("@id_partido", idPartido);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AtualizarCandidato(string nomeCandidato, string apelido, int numero, string idPartido)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "UPDATE candidato SET numero = @numero, nome = @nome, apelido = @apelido, id_partido = @idPartido WHERE id_coligacao = 1;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@nome", nomeCandidato);
                    command.Parameters.AddWithValue("@apelido", apelido);
                    command.Parameters.AddWithValue("@idPartido", idPartido);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeletarCandidato(int numero, string nome, string apelido)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM candidato WHERE numero = @numero and nome = @nome and apelido = @apelido";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@apelido", apelido);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
