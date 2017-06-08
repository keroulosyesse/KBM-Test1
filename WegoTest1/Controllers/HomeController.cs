using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WegoTest1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //TEST WEGO
        // TEST Boka 
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult AboutUs()
        {
            return View(); //donot have to define the name especially if the view has the same name of the action
        }
        public ActionResult Test()
        {
            return View("Test");
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Mission()
        {
            return View();
        }
        public ActionResult Vision()
        {
            return View();
        }

    }
}
