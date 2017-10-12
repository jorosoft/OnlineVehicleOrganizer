namespace OVO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDBrestrictions : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Models", new[] { "Name" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Models", "Name", unique: true);
        }
    }
}
