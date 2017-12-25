using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class DestinationRepository : Repository<Destination>
    {
        public DestinationRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}