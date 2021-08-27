using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class DBObjects
    {
        public static void Initial(CarShopDBContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Cars.Any())
            {
                context.AddRange
                (
                    new Car
                    {
                        Name = "Tesla Model 3",
                        ShortDescription = "Самый продаваемый электромобиль в истории",
                        LongDescription = "Прекрасный и быстрый электромобиль",
                        Image = "/img/tesla.jpg",
                        Price = 2581000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Lada Vesta",
                        ShortDescription = "Новая Лада",
                        LongDescription = "Говорят, что стала лучше предшественниц...",
                        Image = "/img/vesta.png",
                        Price = 10000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Автомобили"]
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{CategoryName = "Электромобили", CategoryDescription = "Автомобили с электро-мотором"},
                        new Category{CategoryName = "Автомобили", CategoryDescription = "Автомобили с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category element in list)
                    {
                        category.Add(element.CategoryName, element);
                    }
                }

                return category;
            }
        }
    }
}
