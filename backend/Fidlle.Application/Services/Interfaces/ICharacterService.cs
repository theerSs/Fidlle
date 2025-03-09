using Fidlle.Application.DTO;
using Fidlle.Domain.Entities;

namespace Fidlle.Application.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<Character> CreateCharacterAsync(CreateCharacterDto createCharacterDto, Guid userId);
    }
}
