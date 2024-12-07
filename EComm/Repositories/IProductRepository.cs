using HandsOnMvcClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMvcClass.Repository
{
    internal interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
        Product Get(string id);
        void Edit(Product product);
        void Delete(string id);
    }
}
