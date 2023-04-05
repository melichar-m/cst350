using Milestone_CST350.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;

namespace Milestone_CST350.Controllers
{
    public class RegistrationController : Controller
    {
        string connectionString = "Server=127.0.0.1;Database=cst350_milestone;Uid=root;Pwd=root;";

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult doRegistration(User user)
        {
            string sqlStatement = "INSERT INTO Users (first_name, last_name, Sex, Age, State, Email, Username, Password) " +
             "VALUES (@FirstName, @LastName, @Sex, @Age, @State, @Email, @Username, @Password)";
            // Create a new MySqlConnection object with the connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a new MySqlCommand object with the SQL statement and connection
                using (MySqlCommand cmd = new MySqlCommand(sqlStatement, connection))
                {
                    // Add parameters to the command object
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Sex", user.Sex);
                    cmd.Parameters.AddWithValue("@Age", user.Age);
                    cmd.Parameters.AddWithValue("@State", user.State);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);

                    // Execute the command and get the number of rows affected
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        // Redirect to success page, Login page so that the user has to log in to their account before they can play
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        // If no rows were affected, display an error message
                        ModelState.AddModelError("", "Could not add user to database");
                    }
                }
            }

            // If we got this far, something went wrong, redisplay form with errors
            return View(user);
        }


    }
}