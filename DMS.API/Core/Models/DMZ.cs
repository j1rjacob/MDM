using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class DMZ
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string DMZDescription { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
    }
}