using DMS.API.Core.Models;
using DMS.API.Persistence.EntityConfigurations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DMS.API.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Meter> Meters { get; set; }
        public DbSet<MeterProtocol> MeterProtocols { get; set; }
        public DbSet<MeterSize> MeterSizes { get; set; }
        public DbSet<MeterType> MeterTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<DMZ> Dmzs { get; set; }
        public DbSet<MeterReading> MeterReadings { get; set; }
        public DbSet<LatestMeterReading> LatestMeterReadings { get; set; }
        public DbSet<Gateway> Gateways { get; set; }
        public DbSet<GatewayLog> GatewayLogs { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static Persistence.ApplicationDbContext Create()
        {
            return new Persistence.ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MeterConfiguration());
            modelBuilder.Configurations.Add(new DMZConfiguration());
            modelBuilder.Configurations.Add(new GatewayConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}