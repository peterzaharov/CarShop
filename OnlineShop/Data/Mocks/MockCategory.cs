using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Электромобили", CategoryDescription = "Автомобили с электро-мотором"},
                    new Category{CategoryName = "Автомобили", CategoryDescription = "Автомобили с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
