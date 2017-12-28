using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMS.API.Core.Models
{
    public class City
    {
        public City()
        {
            Meters = new List<Meter>();        
        }
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string CityDescription { get; set; }
        public List<Meter> Meters { get; set; }
    }
}