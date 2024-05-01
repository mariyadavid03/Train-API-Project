using AutoMapper;
using RailwayAPI.DTO;
using RailwayAPI.Model;
namespace RailwayAPI.Profiles
{
    public class ClassProfile:Profile
    {
        public ClassProfile() 
        {
            CreateMap<Class, ClassReadDTO>();
            CreateMap<ClassCreateDTO, Class>();
        }

    }
}
