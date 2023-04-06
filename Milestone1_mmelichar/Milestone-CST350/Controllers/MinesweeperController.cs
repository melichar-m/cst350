using System.Web.Mvc;

namespace Milestone_CST350.Controllers
{
    public class MinesweeperController : Controller
    {
        // GET: Minesweeper
        [HttpGet]
        public ActionResult Index()
        {
            //if user isn't authenticated, redirect them to login
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("Index");
        }
    }

}
