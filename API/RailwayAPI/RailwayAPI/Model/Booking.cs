using System.ComponentModel.DataAnnotations;
namespace RailwayAPI.Model
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public int TrainId { get; set; }
        [Required]
        public int ScheduleId { get; set; }
        [Required]
        public string ClassName { get; set; } = "Not Given";
        [Required]
        public int SeatNo { get; set; }
        [Required]
        public string PassengerNIC { get; set; } = "Not Given";
    }
}
