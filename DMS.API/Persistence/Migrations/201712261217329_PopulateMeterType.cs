using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class PopulateMeterType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MeterTypes(Description) VALUES('MeterType1')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MeterTypes");
        }
    }
}
