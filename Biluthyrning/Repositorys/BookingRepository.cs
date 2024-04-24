using Biluthyrning.Data;
using Biluthyrning.Interface;
using Microsoft.EntityFrameworkCore;


namespace Biluthyrning.Repositorys
{
	public class BookingRepository : IBookingRepository
	{
        private HttpClient client;


        public BookingRepository(HttpClient client)
		{
			this.client = client;
		}

		public async Task CreateBooking(Booking bokning)
		{
			 
                int id = bokning.BookingId;
                client.DefaultRequestHeaders.Clear();
                await client.PutAsJsonAsync($"api/Bookings", bokning);

		}

		public async Task<Booking> ReadBookingById(int BokningId)
		{
            return await client.GetFromJsonAsync<Booking>($"api/Bookings/{BokningId}");

		}

		public async Task UpdateBooking(Booking bokning)
		{

				int id = bokning.BookingId;
				client.DefaultRequestHeaders.Clear();
				await client.PutAsJsonAsync($"api/Bookings", bokning);

		}

		public async Task DeleteBooking(Booking bokning)
		{


				int id = bokning.BookingId;
				client.DefaultRequestHeaders.Clear();
				await client.PutAsJsonAsync($"/api/Bookings", bokning);

		}

		public List<Booking> GetAllBookings()
		{

            return client.GetFromJsonAsync<List<Booking>>("api/Bookings").Result;
		}
	}
}
