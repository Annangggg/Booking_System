using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class UpdateBookingModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
    }
}