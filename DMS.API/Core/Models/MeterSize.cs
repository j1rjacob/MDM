using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class MeterSize
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string SizeDescription { get; set; }
    }
}