using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class CreateBookingModel
    {
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
    }
}