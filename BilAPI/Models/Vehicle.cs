
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BilAPI.Models
{
    public class Vehicle
    {
        [Key, Required]
        public int VehicleId { get; set; }
        public string Color { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        [Required]
        public int VehicleTypeId { get; set; }

        //public List<UserVehicleBooking> UserVehicleBookings { get; set; } = new List<UserVehicleBooking>();
    }
}
