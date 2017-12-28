using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Meters");
            AddPrimaryKey("dbo.Meters", "SerialNumber");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Meters");
            AddPrimaryKey("dbo.Meters", new[] { "SerialNumber", "MeterProtocolId", "MeterSizeId", "MeterTypeId", "CityId", "DMZId" });
        }
    }
}
