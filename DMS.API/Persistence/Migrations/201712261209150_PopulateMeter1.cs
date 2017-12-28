using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class PopulateMeter1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DMZs(Description, CityId) VALUES('DMZ1', 9)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM DMZs");
        }
    }
}
