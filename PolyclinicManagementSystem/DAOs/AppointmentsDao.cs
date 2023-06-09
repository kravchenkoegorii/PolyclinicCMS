﻿using MySql.Data.MySqlClient;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Collections.Generic;

namespace PolyclinicManagementSystem.DAOs
{
    public class AppointmentsDao : IAppointmentsDao
    {
        private readonly string _connectionString = Consts.ConnectionString;

        private IPatientsDao patientDao = new PatientsDao();

        public List<AppointmentModel> GetDoctorAppointments(string name, string surname)
        {
            List<AppointmentModel> result = new List<AppointmentModel>();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT * FROM Appointments ap " +
                $"WHERE ap.doctorname = @val1 " +
                $"AND ap.doctorsurname = @val2";
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
                        AppointmentModel model = new AppointmentModel
                        {
                            Id = reader.GetInt32(0),
                            Date = reader.GetDateTime(1),
                            DoctorName = reader.GetString(2),
                            DoctorSurname = reader.GetString(3),
                            PatientName = reader.GetString(4),
                            PatientSurname = reader.GetString(5)
                        };
                        result.Add(model);
                    }
                }
            }

            connection.Close();

            return result;
        }

        public List<AppointmentModel> GetAllAppointments()
        {
            List<AppointmentModel> result = new List<AppointmentModel>();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT * FROM Appointments";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        AppointmentModel model = new AppointmentModel
                        {
                            Id = reader.GetInt32(0),
                            Date = reader.GetDateTime(1),
                            DoctorName = reader.GetString(2),
                            DoctorSurname = reader.GetString(3),
                            PatientName = reader.GetString(4),
                            PatientSurname = reader.GetString(5)
                        };
                        result.Add(model);
                    }
                }
            }

            connection.Close();

            return result;
        }

        public int GetAppointmentsCount()
        {
            int count = 0;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT COUNT(*) FROM Appointments";
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

        public void AddAppointment(AppointmentModel model)
        {
            string dateStr = model.Date.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SET FOREIGN_KEY_CHECKS=0;\n" +
                $"INSERT INTO `polyclinicdb`.`appointments` " +
                $"(`date`, `doctorname`, `doctorsurname`, `patientname`, `patientsurname`) " +
                $"VALUES ('{dateStr}', '{model.DoctorName}', '{model.DoctorSurname}', " +
                $"'{model.PatientName}', '{model.PatientSurname}');\n" +
                $"SET FOREIGN_KEY_CHECKS=1;";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        void IAppointmentsDao.ChangeAppointment(AppointmentModel model)
        {
            string dateStr = model.Date.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"UPDATE `polyclinicdb`.`appointments` " +
                $"SET `date` = '{dateStr} '" +
                $"WHERE `doctorname` = '{model.DoctorName}' " +
                $"AND `doctorsurname` = '{model.DoctorSurname}' " +
                $"AND `patientname` = '{model.PatientName}' " +
                $"AND `patientsurname` = '{model.PatientSurname}';";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        public bool CheckAppointment(string docSurname, string patSurname)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT ap.id FROM Appointments ap " +
                $"WHERE ap.doctorsurname = @val1 " +
                $"AND ap.patientsurname = @val2;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@val1", docSurname);
            command.Parameters.AddWithValue("@val2", patSurname);
            command.Prepare();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int apId = reader.GetInt32(0);
                        if (apId == 0)
                        {
                            return false;
                        }
                        return true;
                    }
                }
                return false;
            }
        }

        public bool CheckAppointment(string docName, string docSurname, string patName, string patSurname, DateTime date)
        {
            string d = date.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT ap.id FROM Appointments ap " +
                $"WHERE ap.doctorname = '{docName}' " +
                $"AND ap.doctorsurname = '{docSurname}' " +
                $"AND ap.patientname = '{patName}' " +
                $"AND ap.patientsurname = '{patSurname}' " +
                $"AND ap.date = '{d}';";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int apId = reader.GetInt32(0);
                        if (apId == 0)
                        {
                            return false;
                        }
                        return true;
                    }
                }
                return false;
            }
        }

        AppointmentModel IAppointmentsDao.GetAppointment(string docSurname, string patSurname)
        {
            AppointmentModel app = null;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM appointments " +
                $"WHERE `doctorsurname` = '{docSurname}' " +
                $"AND `patientsurname` = '{patSurname}';", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    app = new AppointmentModel
                    {
                        Id = reader.GetInt32(0),
                        Date = reader.GetDateTime(1),
                        DoctorName = reader.GetString(2),
                        DoctorSurname = reader.GetString(3),
                        PatientName = reader.GetString(4),
                        PatientSurname = reader.GetString(5)
                    };
                    break;
                }
            }

            connection.Close();

            return app;
        }
    }
}
