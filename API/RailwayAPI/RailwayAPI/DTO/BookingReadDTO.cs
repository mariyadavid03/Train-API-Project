namespace RailwayAPI.DTO
{
    public class BookingReadDTO
    {
        public int BookingId { get; set; }
        public int TrainId { get; set; }
        public int ScheduleId { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int SeatNo { get; set; }
        public string PassengerNIC { get; set; } = "Not Given";
    }
}
