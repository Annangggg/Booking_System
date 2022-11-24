using Data;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private readonly IBookingRepository BookingRepository;

        public BookingController()
        {
            this.BookingRepository = new BookingRepository();
        }

        // gets all Bookings
        [HttpGet]
        public async Task<ActionResult<List<Booking>>> GetBookings()
        {
            try
            {
                return await BookingRepository.GetAllBookings();
            }
            catch
            {
                return StatusCode(500, $"Could not return Bookings");
            }
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Booking>> GetBooking(int id)
        {
            try
            {
                return await BookingRepository.GetBookingFromIdAsync(id);
            }
            catch
            {
                return StatusCode(500, $"Could not find Booking: {id}");
            }
            

        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingModel createBookingModel)
        {
            try
            {
                await BookingRepository.CreateBookingAsync(createBookingModel);
                return Ok(createBookingModel);
            } 
            catch
            {
                return StatusCode(500, $"Could not create Booking");
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditBooking(UpdateBookingModel updateBookingModel)
        {
            try
            {
                await BookingRepository.UpdateBookingAsync(updateBookingModel);
                return Ok(updateBookingModel);
            }
            catch
            {
                return StatusCode(500, $"Could not update Booking with id: {updateBookingModel.Id}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingAsync(int id)
        {
            try
            {
                await BookingRepository.DeleteBookingAsync(id);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, $"Could not delete Booking with id: {id}");
            }
        }
    }
}
