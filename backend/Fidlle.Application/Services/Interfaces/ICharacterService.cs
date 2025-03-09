using Fidlle.Application.DTO;
using Fidlle.Domain.Entities;

namespace Fidlle.Application.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<CharacterDto> CreateCharacterAsync(CreateCharacterDto createCharacterDto, Guid userId);
        Task<CharacterDto> GetCharacterByIdAsync(Guid characterId);
    }
}
