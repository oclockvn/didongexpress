using didongexpress.bus.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace didongexpress.Controllers
{
    public class HomeController : Controller
    {
        IProductBusiness _productBus = null;

        public HomeController(IProductBusiness productBus)
        {
            _productBus = productBus;
        }

        public ActionResult Index()
        {
            var products = _productBus.AllProducts();

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