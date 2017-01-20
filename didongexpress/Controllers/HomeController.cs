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

        public ActionResult ShoppingGuide()
        {
            return View();
        }
        public ActionResult PaymentGuide()
        {
            return View();
        }
        public ActionResult RecieveGuide()
        {
            return View();
        }
        public ActionResult RefundGuide()
        {
            return View();
        }
        public ActionResult GuaranteeGuide()
        {
            return View();
        }
        public ActionResult SecurityGuide()
        {
            return View();
        }
    }
}