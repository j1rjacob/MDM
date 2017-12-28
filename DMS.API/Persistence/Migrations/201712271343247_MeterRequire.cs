namespace DMS.API.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeterRequire : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Meters", "MeterProtocolId", "dbo.MeterProtocols");
            DropForeignKey("dbo.Meters", "MeterSizeId", "dbo.MeterSizes");
            DropForeignKey("dbo.Meters", "MeterTypeId", "dbo.MeterTypes");
            AddColumn("dbo.Cities", "CityDescription", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.DMZs", "DMZDescription", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.MeterProtocols", "ProtocolDescription", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.MeterSizes", "SizeDescription", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.MeterTypes", "TypeDescription", c => c.String(nullable: false, maxLength: 150));
            AddForeignKey("dbo.Meters", "MeterProtocolId", "dbo.MeterProtocols", "Id");
            AddForeignKey("dbo.Meters", "MeterSizeId", "dbo.MeterSizes", "Id");
            AddForeignKey("dbo.Meters", "MeterTypeId", "dbo.MeterTypes", "Id");
            DropColumn("dbo.Cities", "Description");
            DropColumn("dbo.DMZs", "Description");
            DropColumn("dbo.MeterProtocols", "Description");
            DropColumn("dbo.MeterSizes", "Description");
            DropColumn("dbo.MeterTypes", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MeterTypes", "Description", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.MeterSizes", "Description", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.MeterProtocols", "Description", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.DMZs", "Description", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Cities", "Description", c => c.String(nullable: false, maxLength: 250));
            DropForeignKey("dbo.Meters", "MeterTypeId", "dbo.MeterTypes");
            DropForeignKey("dbo.Meters", "MeterSizeId", "dbo.MeterSizes");
            DropForeignKey("dbo.Meters", "MeterProtocolId", "dbo.MeterProtocols");
            DropColumn("dbo.MeterTypes", "TypeDescription");
            DropColumn("dbo.MeterSizes", "SizeDescription");
            DropColumn("dbo.MeterProtocols", "ProtocolDescription");
            DropColumn("dbo.DMZs", "DMZDescription");
            DropColumn("dbo.Cities", "CityDescription");
            AddForeignKey("dbo.Meters", "MeterTypeId", "dbo.MeterTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Meters", "MeterSizeId", "dbo.MeterSizes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Meters", "MeterProtocolId", "dbo.MeterProtocols", "Id", cascadeDelete: true);
        }
    }
}
