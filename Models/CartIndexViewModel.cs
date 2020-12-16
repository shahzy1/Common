using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ShoppingAssesment.Domain.Entities;

namespace ShoppingAssesment.Models
{
    public class CartIndexViewModel
    {
        public Cart CartVM { get; set; }
        public string ReturnUrl { get; set; }
    }
}
