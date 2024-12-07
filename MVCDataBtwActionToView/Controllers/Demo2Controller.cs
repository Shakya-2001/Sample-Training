using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataBtwActionToView.Controllers
{
    public class Demo2Controller : Controller
    {
        // GET: Demo2t
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult View1() 
        { 
            string flag ="Hello"; TempData["flag"] = flag; //return RedirectToAction("View2"); //redirect is an overload//
            return RedirectToAction("Details", "Demo1");
        }
        public ActionResult View2() { return View(); }

    }
}