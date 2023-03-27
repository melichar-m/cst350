using AppointmentMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppointmentMaker.Controllers
{
    public class AppointmentsController : Controller
    {
        // GET: Appointments
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowAppointmentDetails(AppointmentModel appointment)
        {
            return View(appointment);
        }
    }
}