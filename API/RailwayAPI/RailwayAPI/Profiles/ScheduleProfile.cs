using AutoMapper;
using RailwayAPI.Model;
using RailwayAPI.DTO;
namespace RailwayAPI.Profiles
{
    public class ScheduleProfile:Profile
    {
        public ScheduleProfile() 
        {
            CreateMap<Schedule, ScheduleReadDTO>();
            CreateMap<ScheduleCreateDTO, Schedule>();
        }
    }
}
