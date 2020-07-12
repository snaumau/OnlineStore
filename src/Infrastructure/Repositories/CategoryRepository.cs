using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll => _context.Categories;
    }
}
