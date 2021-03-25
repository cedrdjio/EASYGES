using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EASYGEST.Controllers
{
    public class BlogdetailsController : Controller
    {
        // GET: Blogdetails
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult details()
        {
            return View("details");
        }
    }
}

