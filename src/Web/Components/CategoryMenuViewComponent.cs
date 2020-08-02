using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Components
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenuViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetCategories
                .OrderBy(c => c.Name);

            return View(categories);
        }
    }
}
