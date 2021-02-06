using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingWeb.Models;

namespace ShoppingWeb.ApiCollection.Interfaces
{
    public interface IOrderApi
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
