using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}