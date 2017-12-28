namespace DMS.API.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityRequire : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Meters", "CityId", "dbo.Cities");
            AddColumn("dbo.Meters", "City_Id", c => c.Int());
            CreateIndex("dbo.Meters", "City_Id");
            AddForeignKey("dbo.Meters", "City_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Meters", "CityId", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meters", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Meters", "City_Id", "dbo.Cities");
            DropIndex("dbo.Meters", new[] { "City_Id" });
            DropColumn("dbo.Meters", "City_Id");
            AddForeignKey("dbo.Meters", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
    }
}
