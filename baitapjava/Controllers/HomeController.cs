using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitapjava.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult baitap1c()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult baitap3a()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult baitap3b()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}