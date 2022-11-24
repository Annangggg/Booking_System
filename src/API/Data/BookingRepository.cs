using System.Data;
using Domain;
using System.Data.SqlClient;

namespace Data
{
    public class BookingRepository : IBookingRepository
    {

        string connectionString = ConnectionString.CName;

        public async Task<List<Booking>> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public async Task CreateBookingAsync(CreateBookingModel createBookingModel)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteBookingAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> GetBookingFromIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateBookingAsync(UpdateBookingModel updateBookingModel)
        {
            throw new NotImplementedException();
        }
    }
}