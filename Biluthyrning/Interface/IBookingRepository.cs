using Biluthyrning.Data;

namespace Biluthyrning.Interface
{
    public interface IBookingRepository
    {
        public Task CreateBooking(Booking bokning);
        public Task<Booking> ReadBookingById(int BokningId);
        public Task UpdateBooking(Booking bokning);
        public Task DeleteBooking(Booking bokning);
        public List<Booking> GetAllBookings();
	}
}
