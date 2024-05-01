using System.ComponentModel.DataAnnotations;
namespace RailwayAPI.Model
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        [Required]
        public int TrainId { get; set; }
        [Required]
        public string TrainDate { get; set; } = "Not Given";
        [Required]
        public string StartStation { get; set; } = "Not Given";
        [Required]
        public string EndStation { get; set; } = "Not Given";
        [Required]
        public string StartTime { get; set; } = "Not Given";
        [Required]
        public string ArrivalTime { get; set; } = "Not Given";

    }
}
