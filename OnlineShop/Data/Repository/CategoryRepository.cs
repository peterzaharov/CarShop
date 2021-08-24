using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private CarShopDBContext carShopDBContext;
        public CategoryRepository(CarShopDBContext carShopDBContext)
        {
            this.carShopDBContext = carShopDBContext;
        }
        public IEnumerable<Category> AllCategories => carShopDBContext.Categories;
    }
}
