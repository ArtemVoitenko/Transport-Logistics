using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}