using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class AddLatestMeterReading : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LatestMeterReadings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SerialNumber = c.String(nullable: false),
                        ReadingDate = c.DateTime(nullable: false),
                        ReadingValue = c.String(),
                        LowBatteryAlr = c.Int(nullable: false),
                        LeakAlr = c.Int(nullable: false),
                        MagneticTamperAlr = c.Int(nullable: false),
                        MeterErrorAlr = c.Int(nullable: false),
                        BackFlowAlr = c.Int(nullable: false),
                        BrokenPipeAlr = c.Int(nullable: false),
                        EmptyPipeAlr = c.Int(nullable: false),
                        SpecificErr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LatestMeterReadings");
        }
    }
}
