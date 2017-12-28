using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class MeterProtocol
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string ProtocolDescription { get; set; }
    }
}