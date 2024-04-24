
using System.ComponentModel.DataAnnotations;

namespace BilAPI.Models
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }
        [Required]
        [MaxLength(15), MinLength(3)]
        public string vehicleType { get; set; } = "";
    }
}
