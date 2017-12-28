using System;
using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class Gateway
    {
        [StringLength(100)]
        public string MacAddress { get; set; }
        [Required]
        [StringLength(100)]
        public string SimCard { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public DateTime InstallationDate { get; set; }
        public DateTime MaintenanceDate { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [StringLength(10)]
        public string IPAddress { get; set; }
        public DMZ DMZ { get; set; }
        public int DMZId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; } 
    }
}