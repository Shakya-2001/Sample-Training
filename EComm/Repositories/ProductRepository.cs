using HandsOnMvcClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnMvcClass.Repository
{
    public class ProductRepository : IProductRepository
    {
        private OnlineEcomContext _context;

        public ProductRepository()
        {
            _context = new OnlineEcomContext();
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var product = _context.Products.SingleOrDefault(x => x.ProductId == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void Edit(Product product)
        {
            var obj = _context.Products.SingleOrDefault(x => x.ProductId == product.ProductId);
            obj.Name = product.Name;
            obj.Description = product.Description;
            obj.Price = product.Price;
            _context.SaveChanges();

        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Get(string id)
        {
            var product = _context.Products.Find(id);
            return product;
        }
    }
}