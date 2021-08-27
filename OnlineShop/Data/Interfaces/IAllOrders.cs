using OnlineShop.Data.Models;

namespace OnlineShop.Data.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(Order order);
    }
}
