using ButtonGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ButtonGrid.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random random = new Random();
        const int GRID_SIZE = 25;
        //GET: Button
        public ActionResult Index()
        {
            if (buttons == null || buttons.Count == 0)
            {
                buttons = new List<ButtonModel>();

                for (int i = 0; i < GRID_SIZE; i++)
                {
                    buttons.Add(new ButtonModel(i, random.Next(4)));
                }
            }
            return View("Index", buttons);
        }






        public ActionResult HandleButtonClick(string buttonNumber)
        {

            int bN = int.Parse(buttonNumber);

            buttons.ElementAt(bN).ButtonState = (buttons.ElementAt(bN).ButtonState + 1) % 4;

            return View("Index", buttons);
        }

    }
}