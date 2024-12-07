using HandsOnMvcClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Repositories
{
    internal interface IOrderRepository
    {
        List<Order> GetAll();
        void MakeOrder(Order order);
        Order GetOrder(string id);
        void DeleteOrder(string id);
        List<Order> OrdersByProduct(string productId);
    }
}
