using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsInStock { get; set; }
        public bool IsDeleted { get; set; }
          public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }


        public Product(string name, double unitPrice)
        {
            Name = name;
            IsInStock = true;
            UnitPrice = unitPrice;
            CreateDate = DateTime.Now;
        }
        public void Restore()
        {
            IsDeleted = false;
        }
    }
}
