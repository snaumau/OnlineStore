using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult List(string currentCategory)
        {
            IEnumerable<Product> products;

            if (string.IsNullOrEmpty(currentCategory))
            {
                products = _productRepository.Products
                    .OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.Products
                    .Where(p => p.Category.Name == currentCategory)
                    .OrderBy(p => p.ProductId);
            }
            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory,
            });
        }

        public IActionResult Details(int productId)
        {
            var product = _productRepository.GetProductById(productId);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
