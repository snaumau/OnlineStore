using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCartService _shoppingCart;

        public ShoppingCartSummary(ShoppingCartService shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };
            return View(shoppingCartViewModel);
        }
    }
}
