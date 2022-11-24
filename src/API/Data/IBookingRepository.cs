using Domain;

namespace Data
{
    public interface IBookingRepository
    {
        public Task<List<Booking>> GetAllBookings();
        public Task<Booking> GetBookingFromIdAsync(int BookingId);
        public Task CreateBookingAsync(CreateBookingModel createBookingModel);
        public Task UpdateBookingAsync(UpdateBookingModel updateBookingModel);
        public Task DeleteBookingAsync(int BookingId);
    }
}