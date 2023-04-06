using MySql.Data.MySqlClient;
using System.Configuration;

namespace Milestone_CST350.Models
{
    public class LoginDAO
    {
        public bool ValidateCredentials(string email, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE email=@Email AND password=@Password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count == 1;
                }
            }
        }
    }
}
