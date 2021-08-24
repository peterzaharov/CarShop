using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private CarShopDBContext carShopDBContext;
        public CarRepository(CarShopDBContext carShopDBContext)
        {
            this.carShopDBContext = carShopDBContext;
        }
        public IEnumerable<Car> AllCars => carShopDBContext.Cars.Include(c => c.Category);

        public IEnumerable<Car> GetFavoriteCars => carShopDBContext.Cars.Where(p => p.IsFavorite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => carShopDBContext.Cars.FirstOrDefault(p => p.Id == carId);
    }
}
