using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataBtwActionToView.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            string title = "Welcome to MVC!!";
            //set title value in ViewData
            ViewData["key"] = title;
            return View();
        }

        public ActionResult Greet(string name)
        {
            ViewData["name"] = name;
            return View();
        }

        public ActionResult Flowers() 
        {
            List<string> flowers = new List<string>() { "Rose","Marigold", "Tulip" };
            ViewData["flowers"] = flowers;
            return View();
        }

    }
}