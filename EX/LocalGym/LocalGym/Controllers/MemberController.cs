using AutoMapper;
using LocalGym.Models;
using LocalGym.Services;
using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{
    [ApiController]
    [Route("api/gym/members")]
    public class MemberController : ControllerBase
    {
        private readonly IGymInfoRepository _gymInfoRespository;
        private readonly IMapper _mapper;


        public MemberController(IGymInfoRepository gymInfoRepository, IMapper mapper) 
        {
            _gymInfoRespository = gymInfoRepository ?? throw new ArgumentNullException(nameof(gymInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetMembers()
        {
            var memberEntities = await _gymInfoRespository.GetMembersAsync();  
            return Ok(_mapper.Map<IEnumerable<MemberDTO>>(memberEntities));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetMember(int id)
        {
            var member = await _gymInfoRespository.GetMemberAsync(id);
            if( member == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MemberDTO>(member));

        }

    }
}
