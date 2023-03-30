using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using MySql.Data.MySqlClient;
using PolyclinicManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PolyclinicManagementSystem.DAOs
{
    public class DoctorsDao : IDoctorsDao
    {
        private string _name;

        private string _surname;

        private readonly string _connectionString = Consts.ConnectionString;

        public string GetName()
        {
            return _name;
        }

        public string GetSurname()
        {
            return _surname;
        }

        public List<DoctorModel> GetAllDoctors()
        {
            List<DoctorModel> results = new List<DoctorModel>();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM doctors", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    DoctorModel doc = new DoctorModel
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Patronymic = reader.GetString(3),
                        BirthDate = reader.GetDateTime(4),
                        Address = reader.GetString(5),
                        PassportCode = reader.GetString(6),
                        PhoneNumber = reader.GetString(7),
                        Email = reader.GetString(8),
                        Specialization = reader.GetString(9),
                        Password = reader.GetString(10)
                    };
                    results.Add(doc);
                }
            }

            connection.Close();

            return results;
        }

        public List<PatientModel> GetAllDoctorPatients(string name, string surname)
        {
            List<PatientModel> results = new List<PatientModel>();

            int id = GetDoctor(name, surname).Id;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM patients " +
                $"WHERE `doctorname` = '{name}' " +
                $"AND `doctorsurname` = '{surname}';", connection);

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
                        DoctorName = reader.GetString(8),
                        DoctorSurname = reader.GetString(9)
                    };
                    results.Add(patient);
                }
            }

            connection.Close();

            return results;
        }

        public bool LoginDoctor(string email, string password)
        {
            LoginDto doc = null;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT d.name, d.surname, d.email, d.password FROM Doctors d WHERE d.email = @val1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@val1", email);
            command.Prepare();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _name = reader.GetString(0);
                        _surname = reader.GetString(1);
                        doc = new LoginDto
                        {
                            Email = reader.GetString(2),
                            Password = reader.GetString(3)
                        };
                        break;
                    }
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }

            connection.Close();

            return !string.IsNullOrEmpty(doc.Email) && doc.Password == password;
        }

        public void AddDoctor(DoctorModel doctor)
        {
            string dateStr = doctor.BirthDate.ToString("yyyy-MM-dd");
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SET FOREIGN_KEY_CHECKS=0;\n" +
                $"INSERT INTO `polyclinicdb`.`doctors` " +
                $"(`name`, `surname`, `patronymic`, `birthdate`, " +
                $"`adress`, `passportcode`, `phonenumber`, `email`, `specialization`, `password`) " +
                $"VALUES ('{doctor.Name}', '{doctor.Surname}', '{doctor.Patronymic}', '{dateStr}', '{doctor.Address}', " +
                $"'{doctor.PassportCode}', '{doctor.PhoneNumber}', '{doctor.Email}', '{doctor.Specialization}', '{doctor.Password}');\n" +
                $"SET FOREIGN_KEY_CHECKS=1;";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        public void ChangeDoctor(DoctorModel newDoctor)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"UPDATE `polyclinicdb`.`doctors` " +
            $"SET `adress` = '{newDoctor.Address}', `phonenumber` = '{newDoctor.PhoneNumber}', " +
            $"`email` = '{newDoctor.Email}', `specialization` = '{newDoctor.Specialization}' " +
            $"WHERE `name` = '{newDoctor.Name}' " +
            $"AND `surname` = '{newDoctor.Surname}';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        public DoctorModel GetDoctor(string name, string surname)
        {
            DoctorModel doc = new DoctorModel();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM Doctors " +
                $"WHERE name = '{name}' " +
                $"AND surname = '{surname}';", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    doc = new DoctorModel
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Patronymic = reader.GetString(3),
                        BirthDate = reader.GetDateTime(4),
                        Address = reader.GetString(5),
                        PassportCode = reader.GetString(6),
                        PhoneNumber = reader.GetString(7),
                        Email = reader.GetString(8),
                        Specialization = reader.GetString(9),
                        Password = reader.GetString(10)
                    };
                    break;
                }
            }

            connection.Close();

            return doc;
        }

        bool IDoctorsDao.CheckDoctor(string name, string surname)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT d.name, d.surname FROM Doctors d " +
                $"WHERE d.name = @val1 " +
                $"AND d.surname = @val2;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@val1", name);
            command.Parameters.AddWithValue("@val2", surname);
            command.Prepare();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        name = reader.GetString(0);
                        surname = reader.GetString(1);
                        if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(surname))
                        {
                            return false;
                        }
                        return true;
                    }
                }
                return false;
            }
        }
    }
}