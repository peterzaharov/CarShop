using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory carsCategory;
        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            this.allCars = allCars;
            this.carsCategory = carsCategory;
        }
        public ViewResult ListCars()
        {
            ViewBag.Category = "Some new";
            var cars = allCars.AllCars;
            return View(cars);
        }
    }
}
