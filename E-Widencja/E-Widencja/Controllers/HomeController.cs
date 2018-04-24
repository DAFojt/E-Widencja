using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Widencja.Controllers
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

        public ActionResult EmployeeEdit()
        {
            ViewBag.Message = "Twój pracownik.";

            return View();
        }

        public ActionResult EmployeeView()
        {
            ViewBag.Message = "Twój pracownik.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult ActionPartialView(string s)

        {
            return PartialView(s);
        }
    }
}