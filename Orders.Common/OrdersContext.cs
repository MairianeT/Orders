using Microsoft.EntityFrameworkCore;
using Orders.Common.Models;

namespace Orders.Common
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; } 
    }
}