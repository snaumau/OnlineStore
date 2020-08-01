using ApplicationCore.Entities;
using System.Linq;

namespace ApplicationCore.Interfaces
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories { get; }
    }
}
