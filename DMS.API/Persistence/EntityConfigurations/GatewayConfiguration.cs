using System.Data.Entity.ModelConfiguration;
using DMS.API.Core.Models;

namespace DMS.API.Persistence.EntityConfigurations
{
    internal class GatewayConfiguration : EntityTypeConfiguration<Gateway>
    {
        public GatewayConfiguration()
        {
            Property(c => c.CityId)
                .IsRequired();

            Property(d => d.DMZId)
                .IsRequired();

            HasKey(a => new
            {
                a.MacAddress
            });

            HasRequired(a => a.DMZ)
                .WithMany()
                .HasForeignKey(fk => fk.DMZId)
                .WillCascadeOnDelete(false);
        }
    }
}