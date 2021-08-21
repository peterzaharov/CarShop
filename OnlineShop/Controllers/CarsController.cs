using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using OnlineShop.ViewModels;
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
            ViewBag.Title = "Страница с автомобилями";
            CarListViewModel obj = new CarListViewModel();
            obj.AllCars = allCars.AllCars;
            obj.CarCategory = "Автомобили";
            return View(obj);
        }
    }
}
