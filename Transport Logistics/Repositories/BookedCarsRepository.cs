using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class BookedCarsRepository : Repository<BookedCar>
    {
        public BookedCarsRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}