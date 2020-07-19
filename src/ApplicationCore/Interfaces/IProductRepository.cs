using ApplicationCore.Entities;
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> Products { get; }

        Product GetProductById(int productId);
    }
}
