using Fidlle.Application.DTO;
using Fidlle.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Fidlle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CharacterController(ICharacterService characterService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateCharacter([FromBody] CreateCharacterDto createCharacterDto)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if(userIdClaim == null)
            {
                return Unauthorized();
            }

            var userId = Guid.Parse(userIdClaim.Value);

            var character = await characterService.CreateCharacterAsync(createCharacterDto, userId);

            return CreatedAtAction(nameof(GetCharacter), new { id = character.Id }, character);
        }

        [HttpGet]
        public async Task<IActionResult> GetCharacter(Guid id)
        {
            var characterDto = await characterService.GetCharacterByIdAsync(id);

            return Ok(characterDto);
        }
    }
}
