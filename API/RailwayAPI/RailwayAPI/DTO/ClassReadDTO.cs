namespace RailwayAPI.DTO
{
    public class ClassReadDTO
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int TrainId { get; set; }
        public int NoOfSeats { get; set; }
        public int AvailableSeats { get; set; }
    }
}
