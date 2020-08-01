using ApplicationCore.Entities;
using System.Linq;

namespace Web.ViewModels
{
    public class ProductListViewModel
    {
        public IQueryable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
