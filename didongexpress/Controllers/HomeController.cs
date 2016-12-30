using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace didongexpress.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            "hasd".Prefix("c#");

            return View();
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}