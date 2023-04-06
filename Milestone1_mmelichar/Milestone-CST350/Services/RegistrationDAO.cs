using MySql.Data.MySqlClient;
using System;

namespace Milestone_CST350
{
    public class RegistrationDao
    {
        private MySqlConnection connection;
        private string connectionString;

        public RegistrationDao(string server, string database, string uid, string password)
        {
            connectionString = $"SERVER=127.0.0.1;DATABASE=cst350_milestone;UID=root;PASSWORD=root;";
            connection = new MySqlConnection(connectionString);
        }

        public bool RegisterUser(string firstName, string lastName, string sex, int age, string state, string email, string username, string password)
        {
            bool success = false;

            try
            {
                connection.Open();

                string query = "INSERT INTO users (first_name, last_name, sex, age, state, email, username, password) VALUES (@FirstName, @LastName, @Sex, @Age, @State, @Email, @Username, @Password)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return success;
        }
    }
}
