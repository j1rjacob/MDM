using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class PopulateMeterSize : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MeterSizes(Description) VALUES('Size1')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MeterSizes");
        }
    }
}
