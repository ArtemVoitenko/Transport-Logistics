using System.Data.Entity;
using Transport_Logistics.Entities;

namespace Transport_Logistics.Context
{
    public class TransportDbContext : DbContext
    {
        public DbSet<BookedCar> BookedCars { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDirectory> CarDirectories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}