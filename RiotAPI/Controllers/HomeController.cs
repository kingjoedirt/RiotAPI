using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RiotAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RiotAPI.Repos.RiotRepo riotRepo = new Repos.RiotRepo();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}