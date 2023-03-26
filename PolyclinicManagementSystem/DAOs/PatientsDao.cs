using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PolyclinicManagementSystem.Models;

namespace PolyclinicManagementSystem.DAOs
{
    public class PatientsDao : IPatientsDao
    {
        private readonly string _connectionString = Consts.ConnectionString;

        public int GetPatientsCount()
        {
            int count = 0;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT COUNT(*) FROM Patients";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
            }

            connection.Close();

            return count;
        }

        public void AddPattient(PatientModel patient)
        {
            string dateStr = patient.BirthDate.ToString("yyyy-MM-dd");
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SET FOREIGN_KEY_CHECKS=0;\n" +
                $"INSERT INTO `polyclinicdb`.`patients` " +
                $"(`id`, `name`, `surname`, `patronymic`, `birthdate`, `adress`, `passportcode`, `phonenumber`, `doctorid`) " +
                $"VALUES ('{patient.Id}', '{patient.Name}', '{patient.Surname}', '{patient.Patronymic}'," +
                $"'{dateStr}', '{patient.Address}', '{patient.PassportCode}', '{patient.PhoneNumber}', '{patient.DoctorId}');\n" +
                $"SET FOREIGN_KEY_CHECKS=1;";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        public void ChangePatient(PatientModel newPatient)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SET FOREIGN_KEY_CHECKS=0;\n" +
            $"UPDATE `polyclinicdb`.`patients` " +
            $"SET `adress` = '{newPatient.Address}', `phonenumber` = '{newPatient.PhoneNumber}' " +
            $"WHERE (`id` = '{newPatient.Id}');" +
            $"SET FOREIGN_KEY_CHECKS=1;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        public List<PatientModel> GetAllPatients()
        {
            List<PatientModel> results = new List<PatientModel>();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM patients", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    PatientModel patient = new PatientModel()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Patronymic = reader.GetString(3),
                        BirthDate = reader.GetDateTime(4),
                        Address = reader.GetString(5),
                        PassportCode = reader.GetString(6),
                        PhoneNumber = reader.GetString(7),
                        DoctorId = reader.GetInt32(8)
                    };
                    results.Add(patient);
                }
            }

            connection.Close();

            return results; 
        }

        public bool CheckPatient(int patId)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT p.name FROM Patients p WHERE p.id = @val1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@val1", patId);
            command.Prepare();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        if(name == null || name == "")
                        {
                            return false;
                        }
                        return true;
                    }
                }
                return false;
            }
        }

        PatientModel IPatientsDao.GetPatient(int id)
        {
            PatientModel pat = null;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM patients WHERE id = {id}", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    pat = new PatientModel
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Patronymic = reader.GetString(3),
                        BirthDate = reader.GetDateTime(4),
                        Address = reader.GetString(5),
                        PassportCode = reader.GetString(6),
                        PhoneNumber = reader.GetString(7),
                        DoctorId = reader.GetInt32(8)
                    };
                    break;
                }
            }

            connection.Close();

            return pat;
        }
    }
}