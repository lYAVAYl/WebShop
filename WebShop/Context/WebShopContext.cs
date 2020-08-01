using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebShop.Models;

namespace WebShop.Context
{
    public class WebShopContext : DbContext
    {
        public WebShopContext() : base("WebShopDB")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }



    }
}