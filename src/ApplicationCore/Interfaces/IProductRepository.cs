using ApplicationCore.Entities;
using System.Linq;

namespace ApplicationCore.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts { get; }

        Product GetProductById(int productId);
    }
}
