using AutoMapper;
using RailwayAPI.Model;
using RailwayAPI.DTO;
namespace RailwayAPI.Profiles
{
    public class BookingProfile:Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking,BookingReadDTO>();
            CreateMap<BookingCreateDTO, Booking>();
        }
    }
}
