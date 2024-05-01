using Microsoft.AspNetCore.Mvc;
using RailwayAPI.Model;
using RailwayAPI.Data;
using RailwayAPI.DTO;
using AutoMapper;

namespace RailwayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : Controller
    {
        private readonly IMapper mapper;
        private readonly SeatRepository repository;

        public SeatController(SeatRepository seatRepository, IMapper _mapper)
        {
            repository = seatRepository;
            mapper = _mapper;
        }
        [HttpPost]
        public ActionResult CreateSeat(SeatCreateDTO createDTO)
        {
            var seat = mapper.Map<Seat>(createDTO);
            if (repository.CreateSeat(seat))
                return Ok();
            else
                return BadRequest();
        }
        [HttpGet("{SeatId}", Name = "GetBySeatId")]
        public ActionResult<SeatReadDTO> GetSeat(int id)
        {
            var seat = repository.GetSeat(id);
            if (seat != null)
                return Ok(mapper.Map<SeatReadDTO>(seat));
            else
                return NotFound();
        }
        [HttpGet]
        public ActionResult<IEnumerable<SeatReadDTO>> GetSeats()
        {
            var seat = repository.GetSeats();
            return Ok(mapper.Map<IEnumerable<SeatReadDTO>>(seat));
        }


        [HttpPut("{SeatId}")]
        public ActionResult UpdateSeat(int id, SeatCreateDTO createDTO)
        {
            var seat = mapper.Map<Seat>(createDTO);
            seat.SeatId = id;
            if (repository.UpdateSeat(seat))
                return Ok();
            else
                return NotFound();
        }
        [HttpGet("GetBookedSeatNumbers")]
        public ActionResult<List<int>> GetBookedSeatNumbers([FromQuery] int trainId, [FromQuery] string className)
        {
            var result = repository.GetBookedSeatNumbers(trainId, className);
            return Ok(result);
        }
    }
}
