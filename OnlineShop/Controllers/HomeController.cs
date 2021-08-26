using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars allCars;
        public HomeController(IAllCars allCars)
        {
            this.allCars = allCars;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavoriteCars = allCars.GetFavoriteCars
            };

            return View(homeCars);
        }
    }
}
