using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class CarRepository : Repository<Car>
    {
        public CarRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}