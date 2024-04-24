namespace Biluthyrning.Data
{
    //ANVÄNDS EJ JUST NU
	public class UserVehicleBooking
	{
        public int UserId { get; set; }
        public User User { get; set; }

        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }


    }
}
