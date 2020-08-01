using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Category> GetCategories => _context.Categories;
    }
}
