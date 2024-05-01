using System.ComponentModel.DataAnnotations;

namespace RailwayAPI.DTO
{
    public class ScheduleReadDTO
    {
        public int ScheduleId { get; set; }
        public int TrainId { get; set; }
        public string TrainDate { get; set; } = "Not Given";
        public string StartStation { get; set; } = "Not Given";
        public string EndStation { get; set; } = "Not Given";
        public string StartTime { get; set; } = "Not Given";
        public string ArrivalTime { get; set; } = "Not Given";

    }
}
