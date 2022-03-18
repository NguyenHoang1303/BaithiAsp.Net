using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaicEcommerce.Models
{
    public class Category
    {
        
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public List<Product> Product { get; set; }

    }
}