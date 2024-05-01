using AutoMapper;
using RailwayAPI.Model;
using RailwayAPI.DTO;

namespace RailwayAPI.Profiles
{
    public class SeatProfile:Profile
    {
        public SeatProfile() 
        {
            CreateMap<Seat, SeatReadDTO>();
            CreateMap<SeatCreateDTO, Seat>();
        }
    }
}
