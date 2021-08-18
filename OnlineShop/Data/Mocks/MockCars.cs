using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();
        public IEnumerable<Car> AllCars
        {
            get
            {
                return new List<Car>
                {
                    new Car{ Name = "Tesla", ShortDescription = "", LongDescription = "", Image = "",
                             Price = 50000, IsFavorite = true, Available = true, Category = carsCategory.AllCategories.First() }
                };
            }
        }
        public IEnumerable<Car> GetFavoriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
