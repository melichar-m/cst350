using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace activity1_mmelichar.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.name = "Mike";
            ViewBag.secretNumber = 2313;
            return View();
        }
    }
}