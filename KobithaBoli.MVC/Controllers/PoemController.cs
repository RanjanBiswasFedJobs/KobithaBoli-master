using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace KobithaBoli.MVC.Controllers
{
    public class PoemController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult Detail()
        {
            return View();

        }

      

    }
}
