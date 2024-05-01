using Microsoft.AspNetCore.Mvc;
using RailwayAPI.Model;
using RailwayAPI.Data;
using RailwayAPI.DTO;
using AutoMapper;

namespace RailwayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookingController : Controller
    {
        private readonly IMapper mapper;
        private readonly BookingRepository repository;

        public BookingController(BookingRepository bookRepository, IMapper _mapper)
        {
            repository = bookRepository;
            mapper = _mapper; 
        }
        [HttpPost]
        public ActionResult CreateBooking(BookingCreateDTO bookCreate)
        {
            var booking = mapper.Map<Booking>(bookCreate);
            if(repository.CreateBooking(booking))
                return Ok();
            else
                return BadRequest();
        }
        [HttpGet("{BookingId}", Name = "GetByBookingID")]
        public ActionResult<BookingReadDTO> GetBooking(int id)
        {
            var book = repository.GetBooking(id);
            if(book != null)
                return Ok(mapper.Map<BookingReadDTO>(book));
            else
                return NotFound();
        }
        [HttpGet]
        public ActionResult<IEnumerable<BookingReadDTO>> GetBookings()
        {
            var book = repository.GetBookings();
            return Ok(mapper.Map<IEnumerable<BookingReadDTO>>(book));
        }
        [HttpDelete("{BookingId}")]
        public ActionResult DeleteBooking(int id)
        {
            var book = repository.GetBooking(id);
            if (book != null)
            {
                repository.RemoveBooking(book);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("check/{passengerNIC}/{trainId}/{scheduleId}")]
        public IActionResult CheckBookingLimit(string passengerNIC, int trainId, int scheduleId)
        {
            int bookingCount = repository.GetBookingCountByPassengerAndTrain(passengerNIC, trainId,scheduleId);

            if (bookingCount >= 5)
            {
                return BadRequest("Booking limit exceeded for this passenger on this train.");
            }
            else
            {
                return Ok("Booking limit not exceeded.");
            }
        }
        [HttpGet("PassengerSeats")]
        public ActionResult<List<object>> GetPassengerSeats([FromQuery] string passengerNIC, [FromQuery] int trainId, [FromQuery] int scheduleId)
        {
            var passengerSeats = repository.GetPassengerSeats(passengerNIC, trainId, scheduleId);
            return Ok(passengerSeats);
        }


    }
}
