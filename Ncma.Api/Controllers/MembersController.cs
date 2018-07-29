

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ncma.Api.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Core.Members;
    using Dtos;
    using Dtos.DtoExtensionMethods;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService memberService;

        public MembersController(IMemberService memberService)
        {
            this.memberService = memberService;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            MemberServiceModel found = await memberService.GetMemberByIdAsync(id);
            if (found == null)
            {
                return NotFound();
            }

            await memberService.DeleteMemberAsync(id);
            return NoContent();
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<MemberServiceModel> serviceModels = await memberService.GetAllMembers();
            List<MemberDto> dtos = serviceModels.Select(x => new MemberDto(x)).ToList();
            return Ok(dtos);
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name = "GetMember")]
        public async Task<IActionResult> Get(int id)
        {
            MemberServiceModel serviceModel = await memberService.GetMemberByIdAsync(id);
            var dto = new MemberDto(serviceModel);
            return Ok(dto);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MemberDto dto)
        {
            await memberService.SaveMemberAsync(dto.ToServiceModel());
            return CreatedAtRoute("GetMember", new {id = dto.Id}, dto);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] MemberDto dto)
        {
            MemberServiceModel found = await memberService.GetMemberByIdAsync(id);
            if (found == null)
            {
                return NotFound();
            }

            await memberService.SaveMemberAsync(dto.ToServiceModel());
            return NoContent();
        }
    }
}