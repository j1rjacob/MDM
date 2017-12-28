using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class AddStringLength : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Gateways");
            DropPrimaryKey("dbo.Meters");
            AlterColumn("dbo.Cities", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.DMZs", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.GatewayLogs", "GatewayMacAddress", c => c.String(maxLength: 20));
            AlterColumn("dbo.GatewayLogs", "CSVFilename", c => c.String(maxLength: 50));
            AlterColumn("dbo.Gateways", "MacAddress", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Gateways", "SimCard", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Gateways", "Description", c => c.String(maxLength: 250));
            AlterColumn("dbo.Gateways", "Status", c => c.String(maxLength: 10));
            AlterColumn("dbo.Gateways", "IPAddress", c => c.String(maxLength: 10));
            AlterColumn("dbo.LatestMeterReadings", "SerialNumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.LatestMeterReadings", "ReadingValue", c => c.String(maxLength: 100));
            AlterColumn("dbo.MeterProtocols", "Description", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.MeterReadings", "SerialNumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.MeterReadings", "ReadingValue", c => c.String(maxLength: 250));
            AlterColumn("dbo.Meters", "SerialNumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Meters", "Status", c => c.String(maxLength: 10));
            AlterColumn("dbo.Meters", "HCN", c => c.String(maxLength: 150));
            AlterColumn("dbo.MeterSizes", "Description", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.MeterTypes", "Description", c => c.String(nullable: false, maxLength: 150));
            AddPrimaryKey("dbo.Gateways", "MacAddress");
            AddPrimaryKey("dbo.Meters", "SerialNumber");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Meters");
            DropPrimaryKey("dbo.Gateways");
            AlterColumn("dbo.MeterTypes", "Description", c => c.String());
            AlterColumn("dbo.MeterSizes", "Description", c => c.String());
            AlterColumn("dbo.Meters", "HCN", c => c.String());
            AlterColumn("dbo.Meters", "Status", c => c.String());
            AlterColumn("dbo.Meters", "SerialNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.MeterReadings", "ReadingValue", c => c.String());
            AlterColumn("dbo.MeterReadings", "SerialNumber", c => c.String(nullable: false));
            AlterColumn("dbo.MeterProtocols", "Description", c => c.String());
            AlterColumn("dbo.LatestMeterReadings", "ReadingValue", c => c.String());
            AlterColumn("dbo.LatestMeterReadings", "SerialNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Gateways", "IPAddress", c => c.String());
            AlterColumn("dbo.Gateways", "Status", c => c.String());
            AlterColumn("dbo.Gateways", "Description", c => c.String());
            AlterColumn("dbo.Gateways", "SimCard", c => c.String());
            AlterColumn("dbo.Gateways", "MacAddress", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.GatewayLogs", "CSVFilename", c => c.String());
            AlterColumn("dbo.GatewayLogs", "GatewayMacAddress", c => c.String());
            AlterColumn("dbo.DMZs", "Description", c => c.String());
            AlterColumn("dbo.Cities", "Description", c => c.String());
            AddPrimaryKey("dbo.Meters", "SerialNumber");
            AddPrimaryKey("dbo.Gateways", "MacAddress");
        }
    }
}
