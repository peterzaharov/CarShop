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
                    new Car 
                    { 
                        Name = "Tesla",
                        ShortDescription = "Лютая электро-телега", 
                        LongDescription = "Прекрасный и быстрый электромобиль", 
                        Image = "/img/tesla.jpg",
                        Price = 50000, 
                        IsFavorite = true, 
                        Available = true, 
                        Category = carsCategory.AllCategories.First() 
                    },
                    new Car
                    {
                        Name = "Lada Vesta",
                        ShortDescription = "Новая Лада",
                        LongDescription = "Говорят, что стала лучше предшественниц...",
                        Image = "/img/vesta.png",
                        Price = 10000,
                        IsFavorite = false,
                        Available = true,
                        Category = carsCategory.AllCategories.Last()
                    }
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
