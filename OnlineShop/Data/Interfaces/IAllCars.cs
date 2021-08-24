using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> AllCars { get; }
        IEnumerable<Car> GetFavoriteCars { get; }
        Car GetObjectCar(int carId);
    }
}
