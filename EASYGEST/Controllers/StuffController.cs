using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EASYGEST.Controllers
{
    public class StuffController : Controller
    {
        // GET: Stuff
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult stuff()
        {
            return View("stuff");
        }
    }
}

