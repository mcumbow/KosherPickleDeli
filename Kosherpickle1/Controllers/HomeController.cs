using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kosherpickle1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "The Menu.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kosher Pickle Deli Contact Information.";

            return View();
        }
    }
}