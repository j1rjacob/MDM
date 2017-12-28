using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class AddGatewayLog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GatewayLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RDS = c.Int(nullable: false),
                        OMS = c.Int(nullable: false),
                        GatewayMacAddress = c.String(),
                        CSVFilename = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GatewayLogs");
        }
    }
}
