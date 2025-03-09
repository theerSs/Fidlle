using Fidlle.Application.DTO;
using Fidlle.Domain.Entities;

namespace Fidlle.Application.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<CharacterDetailsDto> CreateCharacterAsync(CreateCharacterDto createCharacterDto, Guid userId);
        Task<CharacterDetailsDto> GetCharacterByIdAsync(Guid characterId);
        Task<IEnumerable<CharacterListItemDto>> GetUserCharactersAsync(Guid userId);
    }
}
