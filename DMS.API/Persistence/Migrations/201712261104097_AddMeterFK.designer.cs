// <auto-generated />

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace DMS.API.Persistence.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class AddMeterFK : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddMeterFK));
        
        string IMigrationMetadata.Id
        {
            get { return "201712261104097_AddMeterFK"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
