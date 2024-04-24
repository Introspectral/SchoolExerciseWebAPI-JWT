using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biluthyrning.Data
{
    public class Booking
    {
		//[DateValidation] är en egen ValidationAttribute

		[Key]
        public int BookingId { get; set; }
		[Required, Range(1, int.MaxValue)]
		public int VehicleId { get; set; }
        public int UserId { get; set; }
        public int PricePerDay { get; set; } = 200;
        [DateValidation]
        public DateTime StartDate { get; set; } = DateTime.Today;
        [DateValidation]
        public DateTime EndDate { get; set; } = DateTime.Today;
		//public List<UserVehicleBooking> UserVehicleBookings { get; set; }
	}
}
