using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class PopulateMeterProtocol : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MeterProtocols(Description) VALUES('Protocol1')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MeterProtocols");
        }
    }
}
