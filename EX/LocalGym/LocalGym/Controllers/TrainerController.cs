using AutoMapper;
using LocalGym.Entities;
using LocalGym.Models;
using LocalGym.Services;
using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{
    [ApiController]
    [Route("api/gym/trainers")]
    public class TrainerController : ControllerBase
    {
        private readonly IGymInfoRepository _gymInfoRespository;
        private readonly IMapper _mapper;


        public TrainerController(IGymInfoRepository gymInfoRepository, IMapper mapper)
        {
            _gymInfoRespository = gymInfoRepository ?? throw new ArgumentNullException(nameof(gymInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainerDTO>>> GetTrainers()
        {
            var trainer = await _gymInfoRespository.GetTrainersAsync();
            return Ok(_mapper.Map<IEnumerable<TrainerDTO>>(trainer));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TrainerDTO>>> GetTrainer(int id)
        {
            var trainer = await _gymInfoRespository.GetTrainerAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TrainerDTO>(trainer));

        }
        [HttpPost]
        public async Task<IActionResult> AddTrainer(Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Could not add the trainer.");
            }
            else if(ModelState.IsValid)
            {
                var trainerEntity = _mapper.Map<Trainer>(trainer);
                await _gymInfoRespository.AddTrainerAsync(trainerEntity);

                if (await _gymInfoRespository.SaveChangesAsync())
                {
                    var trainerToReturn = _mapper.Map<TrainerDTO>(trainerEntity);
                    return CreatedAtAction(nameof(GetTrainer), new { id = trainerToReturn.TrainerId }, trainerToReturn);
                }
            }
            return BadRequest("Could not add the trainer.");
            
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> updateTrainer(int id,[FromBody] TrainerUpdateDTO trainer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var oldTrainer = await _gymInfoRespository.GetTrainerAsync(id);
            if (oldTrainer == null)
            {
                return NotFound();
            }
            _mapper.Map(trainer, oldTrainer);


            if (await _gymInfoRespository.SaveChangesAsync())
            {
                return NoContent();
            }


            return StatusCode(500, "An error occurred while updating the trainer.");
        }
    }
}
