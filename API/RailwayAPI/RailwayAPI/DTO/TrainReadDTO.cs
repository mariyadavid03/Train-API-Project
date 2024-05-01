using System.ComponentModel.DataAnnotations;

namespace RailwayAPI.DTO
{
    public class TrainReadDTO
    {
        public int TrainId { get; set; }
        public string TrainNo { get; set; } = "Not Given";
        public string TrainName { get; set; } = "Not Given";
        public string TrainType { get; set; } = "Not Given";

    }
}
