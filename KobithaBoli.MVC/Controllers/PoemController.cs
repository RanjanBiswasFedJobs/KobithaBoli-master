using KobithaBoli.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace KobithaBoli.MVC.Controllers
{
    public class PoemController : Controller
    {

        private KobithaBoliDataContext db = new KobithaBoliDataContext();
        public ActionResult Index()
        {
            //Get a list of all the poems in the database
            return View(db.Poems.ToList());
        }

        [HttpGet]

        public ActionResult Detail()
        {
            return View();

        }

      

    }
}
