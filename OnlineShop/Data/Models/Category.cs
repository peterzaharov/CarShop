using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int CategoryName { get; set; }
        public int CategoryDescription { get; set; }
        public List<Car> Cars { get; set; }
    }
}
