﻿using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavoriteCars { get; set; }
    }
}
