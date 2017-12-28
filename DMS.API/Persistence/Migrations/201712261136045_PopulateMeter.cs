using System.Data.Entity.Migrations;

namespace DMS.API.Persistence.Migrations
{
    public partial class PopulateMeter : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Cities(Description) VALUES('Riyadh')");
            Sql("INSERT INTO DMZs(Description, CityId) VALUES('DMZ1', 9)");
            //Sql("INSERT INTO MeterProtocols(Description) VALUES('Protocol1')");
            //Sql("INSERT INTO MeterSizes(Description) VALUES('Size1')");
            //Sql("INSERT INTO MeterTypes(Description) VALUES('MeterType1')");
            //Sql("INSERT INTO Meters(SerialNumber, MeterProtocolId, MeterSizeId, MeterTypeId, CityId, DMZId, X, Y, Status, HCN, InstallationDate, MaintenanceDate) " +
            //    "VALUES('10042964694', 1, 1, 1, 1, 1, 0.0, 0.0, 'Active', 'HCN', '2017-12-12 16:13:45.000', '2017-12-12 16:13:45.000')");
            
        }
        
        public override void Down()
        {
            //Sql("DELETE FROM Cities");
            Sql("DELETE FROM DMZs");
            //Sql("DELETE FROM MeterProtocols");
            //Sql("DELETE FROM MeterSizes");
            //Sql("DELETE FROM MeterTypes");
            //Sql("DELETE FROM Genres Where Id In ('10042964694')");
        }
    }
}
