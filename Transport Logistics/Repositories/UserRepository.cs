using Transport_Logistics.Context;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(TransportDbContext dbContext) : base(dbContext)
        {
        }
    }
}