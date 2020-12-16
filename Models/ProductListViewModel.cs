using System.Collections.Generic;
using ShoppingAssesment.Domain.Entities;

namespace ShoppingAssesment.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
