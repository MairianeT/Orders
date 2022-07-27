using Orders.BLL.Data;
using Orders.Common.Models;

namespace Orders.BLL.Orders;

public interface IOrdersService
{
    Task<List<Order>> GetAll();
    Task AddOrder(OrderData newOrder);
}