using System.ComponentModel.DataAnnotations;

namespace Domain
{ 
   public class BookingModel
    {
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
    }

}

