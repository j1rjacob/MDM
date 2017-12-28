using System;
using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class MeterReading
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string SerialNumber { get; set; }
        public DateTime ReadingDate { get; set; }
        [StringLength(250)]
        public string ReadingValue { get; set; }
        public int LowBatteryAlr { get; set; }
        public int LeakAlr { get; set; }
        public int MagneticTamperAlr { get; set; }
        public int MeterErrorAlr { get; set; }
        public int BackFlowAlr { get; set; }
        public int BrokenPipeAlr { get; set; }
        public int EmptyPipeAlr { get; set; }
        public int SpecificErr { get; set; }
    }
}