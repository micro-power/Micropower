using Micropower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Micropower.Controllers
{
    public class KolumnatorrController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetStart(SetKolumnatorrModel model)
        {
            return View("Index", model);
        }

    }
}