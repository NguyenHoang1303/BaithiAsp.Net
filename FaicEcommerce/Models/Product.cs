using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaicEcommerce.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public string CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitslnStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }

        public Category Category { get; set; }
    }
}