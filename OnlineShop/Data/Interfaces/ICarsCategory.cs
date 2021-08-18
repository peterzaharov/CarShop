using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
