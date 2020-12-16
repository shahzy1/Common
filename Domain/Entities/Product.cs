using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAssesment.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int InStock { get; set; }

        public static Product[] GetProducts()
        {
            Product p = new Product
            {
                ProductID = 1,
                Name = "Brand jacket",
                Description = "A perfect choice for winter",
                Price = 275M,
                InStock = 2,
            };
            Product p1 = new Product
            {
                ProductID = 2,
                Name = "IPhone 12",
                Description = "A new phone from Apple",                
                Price = 275M,
                InStock = 2,
            };

            return new Product[] { p, p1 };
        }
    }
}
