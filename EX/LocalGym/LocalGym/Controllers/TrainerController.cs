using AutoMapper;
using LocalGym.Entities;
using LocalGym.Models;
using LocalGym.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{
    [ApiController]
    [Authorize]
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
            //when calling repo entity is always passed
            var trainer = await _gymInfoRespository.GetTrainerAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }
            //converting entity to model <return type> to send back the model data to user
            return Ok(_mapper.Map<TrainerDTO>(trainer));

        }
        [HttpPost]
        public async Task<IActionResult> AddTrainer(TrainerDTO trainer)
        {
            //getting model data from user
            if (!ModelState.IsValid)
            {
                return BadRequest(" not able to add the trainer.");
            }
            else if(ModelState.IsValid)
            {
                //converting model to entity <return type>
                var trainerEntity = _mapper.Map<Trainer>(trainer);
                //when calling repo entity is always passed
                await _gymInfoRespository.AddTrainerAsync(trainerEntity);

                if (await _gymInfoRespository.SaveChangesAsync())
                {
                    //converting model to entity
                    var trainerToReturn = _mapper.Map<TrainerDTO>(trainerEntity);
                    return CreatedAtAction(nameof(GetTrainer), new { id = trainerToReturn.TrainerId }, trainerToReturn);
                }
            }
            return BadRequest("Not able to add the trainer.");
            
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> updateTrainer(int id,[FromBody] TrainerUpdateDTO trainer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingTrainer = await _gymInfoRespository.GetTrainerAsync(id);
            if (existingTrainer == null)
            {
                return NotFound();
            }
            _mapper.Map(trainer, existingTrainer);


            if (await _gymInfoRespository.SaveChangesAsync())
            {
                return NoContent();
            }


            return StatusCode(500, "An error occurred while updating the trainer.");
        }
    }
}
