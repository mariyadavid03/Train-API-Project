using Microsoft.AspNetCore.Mvc;
using RailwayAPI.Model;
using RailwayAPI.Data;
using RailwayAPI.DTO;
using AutoMapper;

namespace RailwayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TrainController : Controller
    {
        private readonly IMapper mapper;
        private readonly TrainRepository repository;

        public TrainController(TrainRepository trainRepository, IMapper _mapper)
        {
            repository = trainRepository;
            mapper = _mapper; 
        }
        [HttpPost]
        public ActionResult CreateTrain(TrainCreateDTO trainCreate)
        {
            var train = mapper.Map<Train>(trainCreate);
            if(repository.CreateTrain(train))
                return Ok(train.TrainId);
            else
                return BadRequest();
        }
        [HttpGet("{TrainId}", Name = "GetByTrainID")]
        public ActionResult<TrainReadDTO> GetTrain(int id)
        {
            var train = repository.GetTrain(id);
            if(train != null)
                return Ok(mapper.Map<TrainReadDTO>(train));
            else
                return NotFound();
        }
        [HttpGet]
        public ActionResult<IEnumerable<TrainReadDTO>> GetTrains()
        {
            var trains = repository.GetTrains();
            return Ok(mapper.Map<IEnumerable<TrainReadDTO>>(trains));
        }
        [HttpDelete("{TrainId}")]
        public ActionResult DeleteTrain(int id)
        {
            var train = repository.GetTrain(id);
            if (train != null)
            {
                repository.RemoveTrain(train);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut("UpdateTrain/{TrainId}")]
        public ActionResult UpdateTrain(int id,TrainCreateDTO createDTO)
        {
            var train = mapper.Map<Train>(createDTO);
            train.TrainId = id;
            if (repository.UpdateTrain(train))
                return Ok();
            else
                return NotFound();
        }
    }
}
