using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PolyclinicManagementSystem.DAOs
{
    public class AppointmentsDao : IAppointmentsDao
    {
        private readonly string _connectionString = Consts.ConnectionString;

        private IPatientsDao patientDao = new PatientsDao();

        public List<AppointmentModel> GetDoctorAppointments(int docId)
        {
            List<AppointmentModel> result = new List<AppointmentModel>();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT * FROM Appointments ap WHERE ap.doctorid = @val1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@val1", docId);
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
                            DoctorId = reader.GetInt32(2),
                            PatientId = reader.GetInt32(3)
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
                $"(`id`, `date`, `doctorid`, `patientid`) " +
                $"VALUES ('{model.Id}', '{dateStr}', '{model.DoctorId}', '{model.PatientId}');\n" +
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
            string sql = $"SET FOREIGN_KEY_CHECKS=0;\n" +
                $"UPDATE `polyclinicdb`.`appointments` " +
                $"SET `date` = '{dateStr}', `doctorid` = '{model.DoctorId}', " +
                $"`patientid` = '{model.PatientId}' WHERE (`id` = '{model.Id}');\n" +
                $"SET FOREIGN_KEY_CHECKS=1;";
            MySqlCommand command = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = command.ExecuteReader()) { }

            connection.Close();
        }

        public bool CheckAppointment(int id)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT ap.id FROM Appointments ap WHERE ap.id = @val1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@val1", id);
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

        AppointmentModel IAppointmentsDao.GetAppointment(int id)
        {
            AppointmentModel app = null;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM appointments WHERE id = {id}", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    app = new AppointmentModel
                    {
                        Id = reader.GetInt32(0),
                        Date = reader.GetDateTime(1),
                        DoctorId = reader.GetInt32(2),
                        PatientId = reader.GetInt32(3)
                    };
                    break;
                }
            }

            connection.Close();

            return app;
        }
    }
}
