using System.ComponentModel.DataAnnotations;
using Biluthyrning.Data;

namespace Biluthyrning.ViewModels
{
    public class UserVehicleViewModel
    {
        [Required(ErrorMessage = "Epost krävs")]
        public User User { get; set; }
        [Required(ErrorMessage = "Fordon behöver anges")]
        public Vehicle Vehicle { get; set; }
		[Required(ErrorMessage = "Datum krävs")]
		public Booking Booking { get; set; }

        public UserVehicleViewModel()
        {
            User = new User();
            Vehicle = new Vehicle();
            Booking = new Booking();
        }
    }
}
