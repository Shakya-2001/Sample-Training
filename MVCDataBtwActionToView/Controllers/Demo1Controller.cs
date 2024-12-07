using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataBtwActionToView.Controllers
{
    public class Demo1Controller : Controller
    {
        // GET: Demo1
        public ActionResult Index()
        {
            ViewBag.msg = "Demo";
            List<string> list = new List<string>() { "Pune","Mumbai" };
            ViewBag.list = list;
            return View();
        }

        public ActionResult Details() 
        {
            return View();
        }
    }
}