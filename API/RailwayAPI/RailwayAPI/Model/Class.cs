using System.ComponentModel.DataAnnotations;
namespace RailwayAPI.Model
{
    public class Class
    {
        [Key]
        public int ClassId{ get; set; }
        [Required]
        public string ClassName { get; set; } = "Not Given";
        [Required]
        public int TrainId { get; set; }
        [Required]
        public int NoOfSeats { get; set; }
        [Required]
        public int AvailableSeats { get; set; }

    }
}
