using AutoMapper;
using RailwayAPI.Model;
using RailwayAPI.DTO;

namespace RailwayAPI.Profiles
{
    public class TrainProfile:Profile
    {
        public TrainProfile() 
        {
            CreateMap<Train,TrainReadDTO>();
            CreateMap<TrainCreateDTO, Train>();
        }
    }
}
