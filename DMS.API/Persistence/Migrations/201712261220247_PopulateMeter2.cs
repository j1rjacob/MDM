using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class PopulateMeter2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Meters(SerialNumber, MeterProtocolId, MeterSizeId, MeterTypeId, CityId, DMZId, X, Y, Status, HCN, InstallationDate, MaintenanceDate) " +
            "VALUES('10042964694', 1, 1, 1, 9, 8, 0.0, 0.0, 'Active', 'HCN', '2017-12-12 16:13:45.000', '2017-12-12 16:13:45.000')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres Where SerialNumber = '10042964694'");
        }
    }
}
