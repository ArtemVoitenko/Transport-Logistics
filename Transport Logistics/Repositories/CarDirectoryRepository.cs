using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class CarDirectoryRepository : Repository<CarDirectory>
    {
        public CarDirectoryRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}