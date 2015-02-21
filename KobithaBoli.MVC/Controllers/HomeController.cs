using KobithaBoli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace KobithaBoli.MVC.Controllers
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

     [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
         public void Contact(Contact contact)
        {


        }

        public ActionResult Poem()
        {
            ViewBag.Message = "Your Poetry page.";

            return View();
        }
   

    }
}
