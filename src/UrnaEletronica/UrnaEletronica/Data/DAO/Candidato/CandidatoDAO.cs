﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data.DAO.Candidato
{
    internal class CandidatoDAO
    {
        public CandidatoModel BuscarCandidato(int idCandidato)
        {
            CandidatoModel candidato = new CandidatoModel();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM candidato WHERE id_candidato = @idCandidato";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCandidato", idCandidato);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            candidato.IdCandidato = reader.GetInt32("idCandidato");
                            candidato.nome = reader.GetString("nome");
                        }
                    }
                }
            }

            return candidato;
        }
        public List<CandidatoModel> BuscarCandidato()
        {
            List<CandidatoModel> coligacoes = new List<CandidatoModel>();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM candidato";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CandidatoModel candidato = new CandidatoModel();
                            candidato.IdCandidato= reader.GetInt32("id_coligacao");
                            candidato.nome = reader.GetString("nome");

                            coligacoes.Add(candidato);
                        }
                    }
                }
            }

            return coligacoes;
        }
        public void CadastrarCandidato(string nomeCandidato, string apelido, int numero, string idPartido)
        {
            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO candidato (numero, nome, apelido, id_partido) VALUES (@numero, @nome, @apelido, @id_partido)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@nome", nomeCandidato);
                    command.Parameters.AddWithValue("@apelido", apelido);
                    command.Parameters.AddWithValue("@id_partido", idPartido);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarCandidato(string nomeCandidato, string apelido, int numero, string idPartido)
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
    }
}