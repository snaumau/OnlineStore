using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Services
{
    public class ShoppingCartService
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCartService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCartService GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = service.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCartService(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product, int quantity)
        {
            var shoppingCartItems =
                _appDbContext.ShoppingCartItems.SingleOrDefault(s =>
                    s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItems == null)
            {
                shoppingCartItems = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Quantity = 1,
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItems);
            }
            else
            {
                shoppingCartItems.Quantity++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItems =
                _appDbContext.ShoppingCartItems.SingleOrDefault(s =>
                    s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            var localQuantity = 0;

            if (shoppingCartItems != null)
            {
                if (shoppingCartItems.Quantity > 1)
                {
                    shoppingCartItems.Quantity--;
                    localQuantity = shoppingCartItems.Quantity;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItems);
                }
            }
            _appDbContext.SaveChanges();

            return localQuantity;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _appDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Product)
                .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Product.Price * c.Quantity)
                .Sum();

            return total;
        }
    }
}
