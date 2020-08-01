using ApplicationCore.Entities;
using System.Linq;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        public IQueryable<Category> AllCategories { get; set; }
    }
}
