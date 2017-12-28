using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMZs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.MeterProtocols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meters",
                c => new
                    {
                        SerialNumber = c.String(nullable: false, maxLength: 128),
                        MeterProtocolId = c.Int(nullable: false),
                        MeterSizeId = c.Int(nullable: false),
                        MeterTypeId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        DMZId = c.Int(nullable: false),
                        X = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Y = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(),
                        HCN = c.String(),
                        InstallationDate = c.DateTime(nullable: false),
                        MaintenanceDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.SerialNumber, t.MeterProtocolId, t.MeterSizeId, t.MeterTypeId, t.CityId, t.DMZId })
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.DMZs", t => t.DMZId)
                .ForeignKey("dbo.MeterProtocols", t => t.MeterProtocolId, cascadeDelete: true)
                .ForeignKey("dbo.MeterSizes", t => t.MeterSizeId, cascadeDelete: true)
                .ForeignKey("dbo.MeterTypes", t => t.MeterTypeId, cascadeDelete: true)
                .Index(t => t.MeterProtocolId)
                .Index(t => t.MeterSizeId)
                .Index(t => t.MeterTypeId)
                .Index(t => t.CityId)
                .Index(t => t.DMZId);
            
            CreateTable(
                "dbo.MeterSizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MeterTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meters", "MeterTypeId", "dbo.MeterTypes");
            DropForeignKey("dbo.Meters", "MeterSizeId", "dbo.MeterSizes");
            DropForeignKey("dbo.Meters", "MeterProtocolId", "dbo.MeterProtocols");
            DropForeignKey("dbo.Meters", "DMZId", "dbo.DMZs");
            DropForeignKey("dbo.Meters", "CityId", "dbo.Cities");
            DropForeignKey("dbo.DMZs", "CityId", "dbo.Cities");
            DropIndex("dbo.Meters", new[] { "DMZId" });
            DropIndex("dbo.Meters", new[] { "CityId" });
            DropIndex("dbo.Meters", new[] { "MeterTypeId" });
            DropIndex("dbo.Meters", new[] { "MeterSizeId" });
            DropIndex("dbo.Meters", new[] { "MeterProtocolId" });
            DropIndex("dbo.DMZs", new[] { "CityId" });
            DropTable("dbo.MeterTypes");
            DropTable("dbo.MeterSizes");
            DropTable("dbo.Meters");
            DropTable("dbo.MeterProtocols");
            DropTable("dbo.DMZs");
            DropTable("dbo.Cities");
        }
    }
}
