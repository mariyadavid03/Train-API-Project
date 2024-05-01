namespace RailwayAPI.DTO
{
    public class SeatCreateDTO
    {
        public int SeatNo { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int TrainId { get; set; }
        public string SeatStatus { get; set; } = "Available";
    }
}
