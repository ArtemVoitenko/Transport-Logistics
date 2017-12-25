namespace Transport_Logistics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookedCars",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CargoMass = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Distance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CarId = c.Guid(nullable: false),
                        OrderId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.CarId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CarBrandId = c.Guid(nullable: false),
                        DriverId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarDirectories", t => t.CarBrandId, cascadeDelete: true)
                .ForeignKey("dbo.Drivers", t => t.DriverId, cascadeDelete: true)
                .Index(t => t.CarBrandId)
                .Index(t => t.DriverId);
            
            CreateTable(
                "dbo.CarDirectories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CarBrand = c.String(),
                        CarryingCapacity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        OrderDate = c.String(),
                        CustomerId = c.Guid(nullable: false),
                        DestinationId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Destinations", t => t.DestinationId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.DestinationId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Country = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        House = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookedCars", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "DestinationId", "dbo.Destinations");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.BookedCars", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Cars", "CarBrandId", "dbo.CarDirectories");
            DropIndex("dbo.Orders", new[] { "DestinationId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Cars", new[] { "DriverId" });
            DropIndex("dbo.Cars", new[] { "CarBrandId" });
            DropIndex("dbo.BookedCars", new[] { "OrderId" });
            DropIndex("dbo.BookedCars", new[] { "CarId" });
            DropTable("dbo.Users");
            DropTable("dbo.Destinations");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Drivers");
            DropTable("dbo.CarDirectories");
            DropTable("dbo.Cars");
            DropTable("dbo.BookedCars");
        }
    }
}
