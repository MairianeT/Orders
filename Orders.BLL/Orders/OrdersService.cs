using Microsoft.EntityFrameworkCore;
using Orders.BLL.Data;
using Orders.Common;
using Orders.Common.Models;

namespace Orders.BLL.Orders;

public class OrdersService : IOrdersService
{
    private readonly OrdersContext _context;
    
    public OrdersService(OrdersContext context)
    {
        _context = context;
    }
    public async Task<List<Order>> GetAll()
    {
        return await _context.Orders
            .ToListAsync();
    }

    public async Task AddOrder(OrderData newOrder)
    {
        var order = new Order()
        {
            OrderNumber = _context.Orders.ToList().Count + 1,
            SendersCity = newOrder.SendersCity,
            SendersAddress = newOrder.SendersAddress,
            RecipientsCity = newOrder.RecipientsCity,
            RecipientsAddress = newOrder.RecipientsAddress,
            Weight = newOrder.Weight,
            PickupDate = new DateOnly(newOrder.PickupYear, newOrder.PickupMonth, newOrder.PickupDay)
        };

        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
    }
}