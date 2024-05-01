using System.ComponentModel.DataAnnotations;
namespace RailwayAPI.Model
{
    public class Train
    {
        [Key]
        public int TrainId { get; set; }
        [Required]
        public string TrainNo{ get; set; } = "Not Given";
        [Required]
        public string TrainName { get; set; } = "Not Given";
        [Required]
        public string TrainType { get; set; } = "Not Given";

    }
}
