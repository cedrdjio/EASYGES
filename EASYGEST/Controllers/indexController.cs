using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EASYGEST.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View("Home");
        }
    }
}