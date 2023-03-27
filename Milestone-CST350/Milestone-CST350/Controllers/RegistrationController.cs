using Milestone_CST350.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Milestone_CST350.Controllers
{
    public class RegistrationController : Controller
    {
//        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult doRegistration(User user)
        {
            if (ModelState.IsValid)
            {
                //_db.Users.Add(user);
                //_db.SaveChanges();

                // Redirect to success page. Login page for now.
                return RedirectToAction("Login");
            }

            // If we got this far, something went wrong, redisplay form with errors
            return View(user);
        }


    }
}