using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyStuff.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Glenn wants you to see his stuff";

            return View();
        }

        public ActionResult Stuff()
        {
            ViewBag.Message = "I got great stuff";

            return View();
        }
    }
}