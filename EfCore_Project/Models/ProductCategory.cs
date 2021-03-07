using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_Project.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Product { get; set; }
        public ProductCategory(string name)
        {
            Name = name;
            Product = new List<Product>();
        }
    }
}
