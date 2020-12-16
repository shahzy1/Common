using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ShoppingAssesment.Domain.Entities;

namespace ShoppingAssesment.Domain
{
    public class EFStoreRepository : IStoreRepository
    {
        public IQueryable<Product> Products => Product.GetProducts().AsQueryable();
    }
}
