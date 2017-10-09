namespace OVO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeDBRestrictions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VehicleEvents", "Description", c => c.String());
            AlterColumn("dbo.CronJobs", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vehicles", "RegNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Models", "Name", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Manufacturers", "Name", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.VehicleEvents", "Name", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Vehicles", "RegNumber", unique: true);
            CreateIndex("dbo.Models", "Name", unique: true);
            CreateIndex("dbo.Manufacturers", "Name", unique: true);
            DropColumn("dbo.VehicleEvents", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehicleEvents", "Content", c => c.String());
            DropIndex("dbo.Manufacturers", new[] { "Name" });
            DropIndex("dbo.Models", new[] { "Name" });
            DropIndex("dbo.Vehicles", new[] { "RegNumber" });
            AlterColumn("dbo.VehicleEvents", "Name", c => c.String());
            AlterColumn("dbo.Manufacturers", "Name", c => c.String());
            AlterColumn("dbo.Models", "Name", c => c.String());
            AlterColumn("dbo.Vehicles", "RegNumber", c => c.String());
            AlterColumn("dbo.CronJobs", "Name", c => c.String());
            DropColumn("dbo.VehicleEvents", "Description");
        }
    }
}
