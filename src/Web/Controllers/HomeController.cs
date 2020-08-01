using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AllCategories = _categoryRepository.GetCategories
            };
            return View(homeViewModel);
        }
    }
}
