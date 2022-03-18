using FAIC.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace FAIC.Data
{
    public class MyDBContext: DbContext
    {
        public class Context : DbContext
        {
            public Context() : base("FaicDB")
            {

            }
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
        }
    }
}