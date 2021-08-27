using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Models
{
    public class ShopCart
    {
        private CarShopDBContext carShopDBContext;
        public ShopCart(CarShopDBContext carShopDBContext)
        {
            this.carShopDBContext = carShopDBContext;
        }
        public string ShopCarId { get; set; }
        public List<ShopCartItem> ListItems { get; set; }
        public static ShopCart GetCarts(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<CarShopDBContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCarId = shopCartId };
        }
        public void AddToCart(Car car)
        {
            carShopDBContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCarId,
                Car = car,
                Price = car.Price
            });

            carShopDBContext.SaveChanges();
        }
        public List<ShopCartItem> GetShopCartItems()
        {
            return carShopDBContext.ShopCartItems.Where(c => c.ShopCartId == ShopCarId).Include(s => s.Car).ToList();
        }
    }
}
