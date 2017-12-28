using DMS.API.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace DMS.API.Persistence.EntityConfigurations
{
    internal class MeterConfiguration : EntityTypeConfiguration<Meter>
    {
        public MeterConfiguration()
        {
            Property(c => c.CityId)
                .IsRequired();

            Property(d => d.DMZId)
                .IsRequired();

            Property(p => p.MeterProtocolId)
                .IsRequired();

            Property(s => s.MeterSizeId)
                .IsRequired();

            Property(t => t.MeterTypeId)
                .IsRequired();

            HasKey(a => new
            {
                a.SerialNumber
            });

            HasRequired(a => a.DMZ)
                .WithMany()
                .HasForeignKey(fk => fk.DMZId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.City)
                .WithMany()
                .HasForeignKey(fk => fk.CityId)
                .WillCascadeOnDelete(false);

            HasRequired(p => p.MeterProtocol)
                .WithMany()
                .HasForeignKey(fk => fk.MeterProtocolId)
                .WillCascadeOnDelete(false);

            HasRequired(s => s.MeterSize)
                .WithMany()
                .HasForeignKey(fk => fk.MeterSizeId)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.MeterType)
                .WithMany()
                .HasForeignKey(fk => fk.MeterTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}