namespace DMS.API.Persistence.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddNameApplicationName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FullName");
        }
    }
}
