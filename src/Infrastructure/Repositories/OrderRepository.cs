using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using Infrastructure.Services;
using System;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCartService _shoppingCartService;

        public OrderRepository(AppDbContext appDbContext, ShoppingCartService shoppingCartService)
        {
            _appDbContext = appDbContext;
            _shoppingCartService = shoppingCartService;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCartService.ShoppingCartItems;

            order.OrderTotal = _shoppingCartService.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();

            foreach (var cartItems in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Quantity = cartItems.Quantity,
                    ProductId = cartItems.Product.ProductId,
                    Price = cartItems.Product.Price,
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
