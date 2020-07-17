using ApplicationCore.Entities;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> AllCategories { get; set; }
    }
}
