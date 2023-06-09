﻿using MySql.Data.MySqlClient;
using PolyclinicManagementSystem.Models;
using System.Collections.Generic;

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
            string sql = $"INSERT INTO `polyclinicdb`.`patients` " +
                $"(`name`, `surname`, `patronymic`, `birthdate`, `adress`, `passportcode`, `phonenumber`, `doctorname`, `doctorsurname`) " +
                $"VALUES ('{patient.Name}', '{patient.Surname}', '{patient.Patronymic}'," +
                $"'{dateStr}', '{patient.Address}', '{patient.PassportCode}', " +
                $"'{patient.PhoneNumber}', '{patient.DoctorName}', '{patient.DoctorSurname}');";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        public void ChangePatient(PatientModel newPatient)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"UPDATE `polyclinicdb`.`patients` " +
            $"SET `adress` = '{newPatient.Address}', `phonenumber` = '{newPatient.PhoneNumber}' " +
            $"WHERE `name` = '{newPatient.Name}'" +
            $"AND `surname` = '{newPatient.Surname}';";
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
                        DoctorName = reader.GetString(8),
                        DoctorSurname = reader.GetString(9)
                    };
                    results.Add(patient);
                }
            }

            connection.Close();

            return results;
        }

        public bool CheckPatient(string name, string surname)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT p.name, p.surname FROM Patients p " +
                $"WHERE p.name = @val1 " +
                $"AND p.surname = @val2;";
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

        PatientModel IPatientsDao.GetPatient(string name, string surname)
        {
            PatientModel pat = new PatientModel();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM patients " +
                $"WHERE `name` = '{name}' " +
                $"AND `surname` = '{surname}'", connection);

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
                        DoctorName = reader.GetString(8),
                        DoctorSurname = reader.GetString(9)
                    };
                    break;
                }
            }

            connection.Close();

            return pat;
        }
    }
}