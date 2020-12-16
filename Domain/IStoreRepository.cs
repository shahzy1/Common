using System.Collections.Generic;
using System.Linq;

using ShoppingAssesment.Domain.Entities;

namespace ShoppingAssesment.Domain
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
