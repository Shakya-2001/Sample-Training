using HandsOnMvcClass.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnMvcClass.Entities;

namespace HandsOnMvcClass.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();

        }
        public ActionResult Details(string id)
        {

            var product = _productRepository.Get(id);
            return View(product);

        }
        public ActionResult Index()
        {
            var product = _productRepository.GetAll();
            return View(product);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            _productRepository.Add(product);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {

            var product = _productRepository.Get(id);
            return View(product);

        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {

            _productRepository.Edit(product);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(string id)
        {

            _productRepository.Delete(id);
            return RedirectToAction("Index");

        }
    }
}