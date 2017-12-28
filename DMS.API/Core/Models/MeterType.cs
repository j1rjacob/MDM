using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class MeterType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string TypeDescription { get; set; }
    }
}