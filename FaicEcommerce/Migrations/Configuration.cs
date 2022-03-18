namespace FaicEcommerce.Migrations
{
    using FaicEcommerce.Models;
    using FaicEcommerce.Util;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FaicEcommerce.Data.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FaicEcommerce.Data.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            context.Category.AddOrUpdate(
                new Category {Id = "A001" , CategoryName = "Quần Áo", Description="Quần áo dành cho mọi người" , Picture= "A001.png" },
                new Category {Id = "A002" , CategoryName = "Điện thoại", Description= "Điện thoại dành cho mọi người", Picture= "A001.png" },
                new Category {Id = "A003" , CategoryName = "Xe máy", Description= "Xe máy nhập khẩu", Picture= "A001.png" },
                new Category {Id = "A004" , CategoryName = "Đồ chơi", Description= "Đồ chơi dành cho mọi người", Picture= "A001.png" }
           
               );
            context.Product.AddOrUpdate(
                  new Product { Id = GenarateId.Create(),ProductName="Áo dành cho trẻ em", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=100000, UnitslnStock=100, UnitsOnOrder=10, CategoryId="A001" },
                  new Product { Id = GenarateId.Create(),ProductName="Quần dành cho người lớn", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=200000, UnitslnStock=100, UnitsOnOrder=10, CategoryId="A001" },
                  new Product { Id = GenarateId.Create(),ProductName="Điện thoại Iphone 13 Pro MAx", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=20000000, UnitslnStock=100, UnitsOnOrder=10, CategoryId="A002" },
                  new Product { Id = GenarateId.Create(),ProductName="Điện thoại Iphone 11 Pro MAx", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=10000000, UnitslnStock=100, UnitsOnOrder=10, CategoryId="A002" },
                  new Product { Id = GenarateId.Create(),ProductName="Xe máy waye alpha", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=100, UnitslnStock=20000000, UnitsOnOrder=10, CategoryId="A003" },
                  new Product { Id = GenarateId.Create(),ProductName="Xe máy waye dream", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=100, UnitslnStock=20000000, UnitsOnOrder=10, CategoryId="A003" },
                  new Product { Id = GenarateId.Create(),ProductName="Oto MayBach đồ chơi", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=100000, UnitslnStock=100, UnitsOnOrder=10, CategoryId="A004" },
                  new Product { Id = GenarateId.Create(),ProductName="Siêu nhân cho trẻ em", Discontinued=10, ReorderLevel=10, SupplierId=10, QuantityPerUnit=10, UnitPrice=100000, UnitslnStock=100, UnitsOnOrder=10, CategoryId="A004" }
                 
                );
        }
    }
}
