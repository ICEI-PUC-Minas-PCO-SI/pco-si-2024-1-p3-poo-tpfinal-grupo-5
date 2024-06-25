using MySql.Data.MySqlClient;
using System.Collections.Generic;
using UrnaEletronica.Model;


namespace UrnaEletronica.Data.DAO.RelatorioVotacao
{
    static class RelatorioVotacaoDAO
    {
        public static List<VotosCandidatoModel> VotosCandidato(string _cargo)
        {
            List<VotosCandidatoModel> votosList = new List<VotosCandidatoModel>();

            using (MySqlConnection connection = new MySqlConnection(Data.Configs.Consts.ConnectionString))
            {
                connection.Open();

                string query = "SELECT c.id_candidato, c.numero, c.nome, p.sigla, c.cargo, e.quantidade_votos " +
                               "FROM urna.eleicao_candidato e " +
                               "JOIN urna.candidato c ON e.id_candidato = c.id_candidato " +
                               "JOIN urna.partido p ON p.id_partido = c.id_partido " +
                               "WHERE c.cargo = @_cargo " +
                               "ORDER BY e.quantidade_votos DESC;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@_cargo", _cargo);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VotosCandidatoModel votos = new VotosCandidatoModel
                            {
                                id_candidato = reader.GetInt32("id_candidato"),
                                numero = reader.GetInt32("numero"),
                                nome = reader.GetString("nome"),
                                sigla = reader.GetString("sigla"),
                                cargo = reader.GetString("cargo"),
                                quandidade_votos = reader.GetInt32("quantidade_votos")
                            };

                            votosList.Add(votos);
                        }
                    }
                }
            }

            return votosList;
        }
    }
}
