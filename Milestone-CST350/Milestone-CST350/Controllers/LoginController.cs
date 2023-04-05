using Milestone_CST350.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Milestone_CST350.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Check if the user exists in the database
            using (var connection = new MySqlConnection($"SERVER=127.0.0.1;DATABASE=cst350_milestone;UID=root;PASSWORD=root;"))
            {
                connection.Open();
                using (var sqlStatement = new MySqlCommand("SELECT id FROM users WHERE email = @Email AND password = @Password", connection))
                {
                    sqlStatement.Parameters.AddWithValue("@Email", model.Email);
                    sqlStatement.Parameters.AddWithValue("@Password", model.Password);
                    var result = sqlStatement.ExecuteScalar();
                    if (result == null)
                    {
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View(model);
                    }
                }
            }

            return RedirectToAction("Index", "Home");
        }

    }

}
