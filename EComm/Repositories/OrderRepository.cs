using HandsOnMvcClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EComm.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OnlineEcomContext context;
        public OrderRepository()
        {
            context = new OnlineEcomContext();
        }
        public void DeleteOrder(string id)
        {
            var o = context.Orders.SingleOrDefault(x=>x.OrderId == id);
            context.Orders.Remove(o);
            context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public Order GetOrder(string id)
        {
            var order = context.Orders.FirstOrDefault(x => x.OrderId == id);
            return order;
        }

        public void MakeOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public List<Order> OrdersByProduct(string productId)
        {
            var order = context.Orders.Where(x => x.ProductId == productId).ToList();

            return order;
        }
    }
   
}