using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
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
        
        [Route("Cars/ListCars")]
        [Route("Cars/ListCars/{carCategory}")]
        public ViewResult ListCars(string carCategory)
        {
            string category = carCategory;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
                cars = allCars.AllCars.OrderBy(i => i.Id);
            else
            {
                if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.AllCars.Where(i => i.Category.CategoryName.Equals("Автомобили")).OrderBy(i => i.Id);
                    currCategory = "Автомобили";
                }
                    
                else if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.AllCars.Where(i => i.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
            }

            CarListViewModel carObj = new CarListViewModel { AllCars = cars, CarCategory = currCategory };

            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }
    }
}
