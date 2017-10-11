using Micropower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Micropower.Controllers
{
    public class HomeController : Controller
    {
        private IDateTimeProvider time;

        public HomeController(IDateTimeProvider dateTimeProvider)
        {
            time = dateTimeProvider;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            NinjectTest test = new NinjectTest(time);

            ViewBag.Message  =test.Value();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}