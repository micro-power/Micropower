using Micropower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Micropower.Controllers
{
    public class KolumnatorOnlineController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetStart(SetKolumnatorModel model)
        {
            return View("Index", model);
        }

    }
}