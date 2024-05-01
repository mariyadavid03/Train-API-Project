using Microsoft.AspNetCore.Mvc;
using RailwayAPI.Model;
using RailwayAPI.Data;
using RailwayAPI.DTO;
using AutoMapper;

namespace RailwayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : Controller
    {
        private readonly IMapper mapper;
        private readonly ClassRepository repository;

        public ClassController(ClassRepository classRepository, IMapper _mapper)
        {
            repository = classRepository;
            mapper = _mapper;
        }
        [HttpPost]
        public ActionResult CreateClass(ClassCreateDTO classCreate)
        {
            var trainClass = mapper.Map<Class>(classCreate);
            if (repository.CreateClass(trainClass))
                return Ok();
            else
                return BadRequest();
        }


        [HttpGet("{ClassId}", Name = "GetByClassId")]
        public ActionResult<ClassReadDTO> GetClass(int id)
        {
            var trainClass = repository.GetClass(id);
            if (trainClass != null)
                return Ok(mapper.Map<ClassReadDTO>(trainClass));
            else
                return NotFound();
        }
        [HttpGet]
        public ActionResult<IEnumerable<ClassReadDTO>> GetClasses()
        {
            var trainClass = repository.GetClasses();
            return Ok(mapper.Map<IEnumerable<ClassReadDTO>>(trainClass));
        }
        [HttpDelete("RemoveClass/{trainId}/{className}")]
        public ActionResult DeleteClass(int trainId, string className)
        {
            var trainClass = repository.GetClassByTrainId(trainId,className);
            if (trainClass != null)
            {
                repository.RemoveClass(trainClass);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut("{ClassId}")]
        public ActionResult UpdateClass(int id, ClassCreateDTO createDTO)
        {
            var trainClass = mapper.Map<Class>(createDTO);
            trainClass.ClassId = id;
            if (repository.UpdateClass(trainClass))
                return Ok();
            else
                return NotFound();
        }

        [HttpPut("UpdateClass/{trainId}/{className}")]
        public ActionResult UpdateClass(int trainId, string className, [FromBody] ClassCreateDTO createDTO)
        {
            var trainClass = mapper.Map<Class>(createDTO);
            if (repository.UpdateClassByTrainId(trainId, className, trainClass))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("TotalSeats")]
        public ActionResult<int> TotalNoOfSeats([FromQuery] int trainId, [FromQuery] string className)
        {
            var result = repository.TotalNoOfSeats(trainId, className);
            return Ok(result);
        }
    }
}
