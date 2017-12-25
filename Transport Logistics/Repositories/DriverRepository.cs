using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class DriverRepository : Repository<Driver>
    {
        public DriverRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}