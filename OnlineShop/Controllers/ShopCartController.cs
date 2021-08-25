using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars carRepository;
        private readonly ShopCart shopCart;
        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            this.carRepository = carRepository;
            this.shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var items = shopCart.GetShopCartItems();
            shopCart.ListItems = items;

            var obj = new ShopCartViewModel { shopCart = shopCart };

            return View(obj);
        }
        public RedirectToActionResult actionResult(int id)
        {
            var item = carRepository.AllCars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                shopCart.AddCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}