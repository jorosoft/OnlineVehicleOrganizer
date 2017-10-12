namespace OVO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDBFKs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CronJobs", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.VehicleEvents", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Models", "Manufacturer_Id", "dbo.Manufacturers");
            DropIndex("dbo.CronJobs", new[] { "Vehicle_Id" });
            DropIndex("dbo.Vehicles", new[] { "Model_Id" });
            DropIndex("dbo.Models", new[] { "Manufacturer_Id" });
            DropIndex("dbo.VehicleEvents", new[] { "Vehicle_Id" });
            RenameColumn(table: "dbo.CronJobs", name: "Vehicle_Id", newName: "VehicleId");
            RenameColumn(table: "dbo.Vehicles", name: "Model_Id", newName: "ModelId");
            RenameColumn(table: "dbo.VehicleEvents", name: "Vehicle_Id", newName: "VehicleId");
            RenameColumn(table: "dbo.Models", name: "Manufacturer_Id", newName: "ManufacturerId");
            AlterColumn("dbo.CronJobs", "VehicleId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Vehicles", "ModelId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Models", "ManufacturerId", c => c.Guid(nullable: false));
            AlterColumn("dbo.VehicleEvents", "VehicleId", c => c.Guid(nullable: false));
            CreateIndex("dbo.CronJobs", "VehicleId");
            CreateIndex("dbo.Vehicles", "ModelId");
            CreateIndex("dbo.Models", "ManufacturerId");
            CreateIndex("dbo.VehicleEvents", "VehicleId");
            AddForeignKey("dbo.CronJobs", "VehicleId", "dbo.Vehicles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Vehicles", "ModelId", "dbo.Models", "Id", cascadeDelete: true);
            AddForeignKey("dbo.VehicleEvents", "VehicleId", "dbo.Vehicles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Models", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.VehicleEvents", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "ModelId", "dbo.Models");
            DropForeignKey("dbo.CronJobs", "VehicleId", "dbo.Vehicles");
            DropIndex("dbo.VehicleEvents", new[] { "VehicleId" });
            DropIndex("dbo.Models", new[] { "ManufacturerId" });
            DropIndex("dbo.Vehicles", new[] { "ModelId" });
            DropIndex("dbo.CronJobs", new[] { "VehicleId" });
            AlterColumn("dbo.VehicleEvents", "VehicleId", c => c.Guid());
            AlterColumn("dbo.Models", "ManufacturerId", c => c.Guid());
            AlterColumn("dbo.Vehicles", "ModelId", c => c.Guid());
            AlterColumn("dbo.CronJobs", "VehicleId", c => c.Guid());
            RenameColumn(table: "dbo.Models", name: "ManufacturerId", newName: "Manufacturer_Id");
            RenameColumn(table: "dbo.VehicleEvents", name: "VehicleId", newName: "Vehicle_Id");
            RenameColumn(table: "dbo.Vehicles", name: "ModelId", newName: "Model_Id");
            RenameColumn(table: "dbo.CronJobs", name: "VehicleId", newName: "Vehicle_Id");
            CreateIndex("dbo.VehicleEvents", "Vehicle_Id");
            CreateIndex("dbo.Models", "Manufacturer_Id");
            CreateIndex("dbo.Vehicles", "Model_Id");
            CreateIndex("dbo.CronJobs", "Vehicle_Id");
            AddForeignKey("dbo.Models", "Manufacturer_Id", "dbo.Manufacturers", "Id");
            AddForeignKey("dbo.VehicleEvents", "Vehicle_Id", "dbo.Vehicles", "Id");
            AddForeignKey("dbo.Vehicles", "Model_Id", "dbo.Models", "Id");
            AddForeignKey("dbo.CronJobs", "Vehicle_Id", "dbo.Vehicles", "Id");
        }
    }
}
