using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class GatewayLog
    {
        public int Id { get; set; }
        public int RDS { get; set; }
        public int OMS { get; set; }
        [StringLength(20)]
        public string GatewayMacAddress { get; set; }
        [StringLength(50)]
        public string CSVFilename { get; set; }
    }
}