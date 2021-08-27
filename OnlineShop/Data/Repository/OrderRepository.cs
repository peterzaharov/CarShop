using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;

namespace OnlineShop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly CarShopDBContext carShopDBContext;
        private readonly ShopCart shopCart;
        public OrderRepository(CarShopDBContext carShopDBContext, ShopCart shopCart)
        {
            this.carShopDBContext = carShopDBContext;
            this.shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.orderDateTime = DateTime.Now;
            carShopDBContext.Orders.Add(order);

            var items = shopCart.ListItems;
            foreach (var item in items)
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = order.Id,
                    CarId = item.Car.Id,
                    Price = item.Car.Price
                };
                carShopDBContext.OrderDetails.Add(orderDetail);
            }

            carShopDBContext.SaveChanges();
        }
    }
}
