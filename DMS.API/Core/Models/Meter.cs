using System;
using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class Meter
    {
        [StringLength(50)]
        public string SerialNumber { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [StringLength(150)]
        public string HCN { get; set; }
        [Required]
        public DateTime InstallationDate { get; set; }
        [Required]
        public DateTime MaintenanceDate { get; set; }
        public MeterType MeterType { get; set; }
        public int MeterTypeId { get; set; }
        public MeterSize MeterSize { get; set; }
        public int MeterSizeId { get; set; }
        public MeterProtocol MeterProtocol { get; set; }
        public int MeterProtocolId { get; set; }
        public DMZ DMZ { get; set; }
        public int DMZId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
    }
}