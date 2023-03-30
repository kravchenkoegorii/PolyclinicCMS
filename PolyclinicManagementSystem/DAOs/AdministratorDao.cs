using MySql.Data.MySqlClient;
using PolyclinicManagementSystem.DAOs.Interfaces;

namespace PolyclinicManagementSystem.DAOs
{
    public class AdministratorDao : IAdministratorDao
    {
        private readonly string _connectionString = Consts.ConnectionString;

        public bool LoginAdmin(string email, string password)
        {
            LoginDto admin = null;

            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            string sql = $"SELECT ad.email, ad.password FROM Administrators ad WHERE ad.email = @val1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@val1", email);
            command.Prepare();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        admin = new LoginDto
                        {
                            Email = reader.GetString(0),
                            Password = reader.GetString(1)
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

            return !string.IsNullOrEmpty(admin.Email) && admin.Password == password;
        }
    }
}
