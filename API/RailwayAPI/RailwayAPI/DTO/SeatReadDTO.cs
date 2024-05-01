using System.ComponentModel.DataAnnotations;

namespace RailwayAPI.DTO
{
    public class SeatReadDTO
    {
        public int SeatId { get; set; }
        public int SeatNo { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int TrainId { get; set; }
        public string SeatStatus { get; set; } = "Available";
    }
}
