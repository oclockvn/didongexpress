using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace didongexpress.Controllers
{
    public class GuideController : Controller
    {
        // GET: Guide
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
    }
}