namespace RailwayAPI.DTO
{
    public class ClassCreateDTO
    {
        public string ClassName { get; set; } = "Not Given";
        public int TrainId { get; set; }
        public int NoOfSeats { get; set; }
        public int AvailableSeats { get; set; }
    }
}
