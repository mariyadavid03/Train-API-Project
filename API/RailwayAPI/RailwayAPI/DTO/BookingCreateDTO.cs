namespace RailwayAPI.DTO
{
    public class BookingCreateDTO
    {
        public int TrainId { get; set; }
        public int ScheduleId { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int SeatNo { get; set; }
        public string PassengerNIC { get; set; } = "Not Given";
    }
}
