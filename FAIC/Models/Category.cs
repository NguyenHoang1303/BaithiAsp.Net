using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAIC.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public List<Product> Products { get; set; }
    }
}