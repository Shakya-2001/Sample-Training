using EComm.Repositories;
using HandsOnMvcClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EComm.Controllers
{
    public class OrderController : Controller
    {
        OrderRepository oR;
        public OrderController()
        {
            oR = new OrderRepository();
        }
        // GET: Order
        public ActionResult Index()
        {
            var orders = oR.GetAll();
            return View(orders);
        }

        public ActionResult Detail(string id)
        {
            var orders = oR.GetOrder(id);
            return View(orders);
        }

        public ActionResult Delete(string id) 
        {
            oR.DeleteOrder(id);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Order order) 
        {
            oR.MakeOrder(order);
            return RedirectToAction("Index");
        }
        public ActionResult Where()
        {
            return View();
        }
        public ActionResult ByProducts(string ProductId)
        {
            var orders=oR.OrdersByProduct(ProductId);
            return View(orders);
        }
    }
}