using FaicEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FaicEcommerce.Data
{
    public class MyContext: DbContext
    {
        public MyContext() : base("ConnectionString")
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}