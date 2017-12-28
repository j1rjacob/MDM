using System.Data.Entity.ModelConfiguration;
using DMS.API.Core.Models;

namespace DMS.API.Persistence.EntityConfigurations
{
    internal class DMZConfiguration : EntityTypeConfiguration<DMZ>
    {
        public DMZConfiguration()
        {
            Property(c => c.CityId)
                .IsRequired();
        }
    }
}