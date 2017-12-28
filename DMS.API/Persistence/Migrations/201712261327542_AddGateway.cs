using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class AddGateway : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gateways",
                c => new
                    {
                        MacAddress = c.String(nullable: false, maxLength: 128),
                        SimCard = c.String(),
                        X = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Y = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        InstallationDate = c.DateTime(nullable: false),
                        MaintenanceDate = c.DateTime(nullable: false),
                        Status = c.String(),
                        IPAddress = c.String(),
                        DMZId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MacAddress)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.DMZs", t => t.DMZId)
                .Index(t => t.DMZId)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gateways", "DMZId", "dbo.DMZs");
            DropForeignKey("dbo.Gateways", "CityId", "dbo.Cities");
            DropIndex("dbo.Gateways", new[] { "CityId" });
            DropIndex("dbo.Gateways", new[] { "DMZId" });
            DropTable("dbo.Gateways");
        }
    }
}
