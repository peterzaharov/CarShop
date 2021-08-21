using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string CarCategory { get; set; }
    }
}
