using activity1_mmelichar.Models;
using activity1_mmelichar.Services;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace activity1_mmelichar.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            CarDataRepository repository = new CarDataRepository();
            return View(repository.AllCars());
        }

        public ActionResult Message()
        {
            return View();
        }
    }
}