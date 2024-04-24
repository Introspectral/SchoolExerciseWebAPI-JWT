using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Biluthyrning.Data
{
	public class VehicleType
	{
        public int VehicleTypeId { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
		[MaxLength(15), MinLength(3)]
        public string vehicleType { get; set; } = "";
    }
}
