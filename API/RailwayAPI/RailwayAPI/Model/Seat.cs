using System.ComponentModel.DataAnnotations;

namespace RailwayAPI.Model
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        [Required]
        public int SeatNo { get; set; }
        [Required]
        public string ClassName{ get; set;} = "Not Given";
        [Required]
        public int TrainId { get; set; }
        [Required]
        public string SeatStatus { get; set; } = "Available";
    }
}
