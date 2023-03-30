using MySql.Data.MySqlClient;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System.Collections.Generic;

namespace PolyclinicManagementSystem.DAOs
{
    public class SpecializationDao : ISpecializationDao
    {
        private readonly string _connectionString = Consts.ConnectionString;

        public List<SpecializationModel> GetAllSpec()
        {
            List<SpecializationModel> results = new List<SpecializationModel>();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM specializations", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SpecializationModel spec = new SpecializationModel
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                    };
                    results.Add(spec);
                }
            }

            connection.Close();

            return results;
        }

        public void AddSpec(SpecializationModel model)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"INSERT INTO `polyclinicdb`.`specializations` (`name`) VALUES ('{model.Name}');";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }
    }
}
