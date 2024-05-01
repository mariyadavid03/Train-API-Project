﻿using System.ComponentModel.DataAnnotations;

namespace RailwayAPI.DTO
{
    public class TrainCreateDTO
    {
        public string TrainNo { get; set; } = "Not Given";
        public string TrainName { get; set; } = "Not Given";
        public string TrainType { get; set; } = "Not Given";
    }
}
