using Microsoft.AspNetCore.Mvc;
using RailwayAPI.Model;
using RailwayAPI.Data;
using RailwayAPI.DTO;
using AutoMapper;

namespace RailwayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : Controller
    {
        private readonly IMapper mapper;
        private readonly ScheduleRepository repository;

        public ScheduleController(ScheduleRepository scheduleRepository, IMapper _mapper)
        {
            repository = scheduleRepository;
            mapper = _mapper;
        }
        [HttpPost]
        public ActionResult CreateSchedule(ScheduleCreateDTO createDTO)
        {
            var schedule = mapper.Map<Schedule>(createDTO);
            if (repository.CreateSchedule(schedule))
                return Ok();
            else
                return BadRequest();
        }
        [HttpGet("{ScheduleId}", Name = "GetByScheduleId")]
        public ActionResult<ScheduleReadDTO> GetSchedule(int id)
        {
            var schedule = repository.GetSchedule(id);
            if (schedule != null)
                return Ok(mapper.Map<ScheduleReadDTO>(schedule));
            else
                return NotFound();
        }
        [HttpGet]
        public ActionResult<IEnumerable<ScheduleReadDTO>> GetSchedules()
        {
            var schedule = repository.GetSchedules();
            return Ok(mapper.Map<IEnumerable<ScheduleReadDTO>>(schedule));
        }

        [HttpDelete("{ScheduleId}")]
        public ActionResult DeleteSchedule(int id)
        {
            var schedule = repository.GetSchedule(id);
            if (schedule != null)
            {
                repository.RemoveSchedule(schedule);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut("{ScheduleId}")]
        public ActionResult UpdateSchedule(int id, ScheduleCreateDTO createDTO)
        {
            var schedule = mapper.Map<Schedule>(createDTO);
            schedule.ScheduleId = id;
            if (repository.UpdateSchedule(schedule))
                return Ok();
            else
                return NotFound();
        }
        [HttpGet("schedules")]
        public ActionResult<IEnumerable<Schedule>> GetSchedules(string date, string startStation, string endStation)
        {
            var schedules = repository.GetSchedulesForDateAndStations(date, startStation, endStation);
            if (schedules != null)
                return Ok(schedules);
            else
                return NotFound();
        }
        [HttpGet("startstations")]
        public ActionResult<IEnumerable<string>> GetAllStartStations()
        {
            var startStations = repository.GetAllStartStations();
            return Ok(startStations);
        }
        [HttpGet("endstations")]
        public ActionResult<IEnumerable<string>> GetAllEndStations()
        {
            var endStations = repository.GetAllEndStations();
            return Ok(endStations);
        }

    }
}
