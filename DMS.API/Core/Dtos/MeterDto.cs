using System;

namespace DMS.API.Core.Dtos
{
    public class MeterDto
    {
        public string SerialNumber { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Status { get; set; }
        public string HCN { get; set; }
        public DateTime InstallationDate { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string MeterType { get; set; }
        public string MeterProtocol { get; set; }
        public string MeterSize { get; set; }
        public string DMZ { get; set; }
        public string City { get; set; }
    }
}