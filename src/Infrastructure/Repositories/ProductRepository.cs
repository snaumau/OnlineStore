using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<Product> GetProducts =>
            _appDbContext.Products.Include(c => c.Category);

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
