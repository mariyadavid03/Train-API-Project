namespace RailwayAPI.DTO
{
    public class ScheduleCreateDTO
    {
        public int TrainId { get; set; }
        public string TrainDate { get; set; } = "Not Given";
        public string StartStation { get; set; } = "Not Given";
        public string EndStation { get; set; } = "Not Given";
        public string StartTime { get; set; } = "Not Given";
        public string ArrivalTime { get; set; } = "Not Given";
    }
}
