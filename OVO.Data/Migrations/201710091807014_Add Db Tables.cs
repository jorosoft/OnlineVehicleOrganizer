namespace OVO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDbTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CronJobs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        PeriodInMonths = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        Vehicle_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RegNumber = c.String(),
                        InsuranceDate = c.DateTime(nullable: false),
                        ServiceDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        Model_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.Model_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.Model_Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        Manufacturer_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.Manufacturer_Id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.VehicleEvents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(),
                        Content = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        Vehicle_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.UserVehicles",
                c => new
                    {
                        User_Id = c.String(nullable: false, maxLength: 128),
                        Vehicle_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Vehicle_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Vehicle_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleEvents", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.UserVehicles", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.UserVehicles", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Vehicles", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Models", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.CronJobs", "Vehicle_Id", "dbo.Vehicles");
            DropIndex("dbo.UserVehicles", new[] { "Vehicle_Id" });
            DropIndex("dbo.UserVehicles", new[] { "User_Id" });
            DropIndex("dbo.VehicleEvents", new[] { "Vehicle_Id" });
            DropIndex("dbo.VehicleEvents", new[] { "IsDeleted" });
            DropIndex("dbo.Manufacturers", new[] { "IsDeleted" });
            DropIndex("dbo.Models", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Models", new[] { "IsDeleted" });
            DropIndex("dbo.Vehicles", new[] { "Model_Id" });
            DropIndex("dbo.Vehicles", new[] { "IsDeleted" });
            DropIndex("dbo.CronJobs", new[] { "Vehicle_Id" });
            DropIndex("dbo.CronJobs", new[] { "IsDeleted" });
            DropTable("dbo.UserVehicles");
            DropTable("dbo.VehicleEvents");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Models");
            DropTable("dbo.Vehicles");
            DropTable("dbo.CronJobs");
        }
    }
}
