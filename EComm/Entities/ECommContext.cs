using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace HandsOnMvcClass.Entities
{
    public class OnlineEcomContext : DbContext
    {
        public OnlineEcomContext() : base("OnlineDbEcomConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}