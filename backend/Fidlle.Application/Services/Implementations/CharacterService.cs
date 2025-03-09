using Fidlle.Application.DTO;
using Fidlle.Application.Exceptions;
using Fidlle.Application.IRepositories;
using Fidlle.Application.Services.Interfaces;
using Fidlle.Domain.Entities;
using Fidlle.Domain.Interfaces;

namespace Fidlle.Application.Services.Implementations
{
    public class CharacterService(ICharacterRepository characterRepository, IUserRepository userRepository) : ICharacterService
    {
        public async Task<CharacterDto> CreateCharacterAsync(CreateCharacterDto createCharacterDto, Guid userId)
        {
            var user = await userRepository.GetUserByIdAsync(userId) ?? throw new NotFoundException("User not found");

            var character = new Character
            {
                Id = Guid.NewGuid(),
                Name = createCharacterDto.Name,
                Class = createCharacterDto.Class,
                UserId = userId,
                User = user
            };

            await characterRepository.AddAsync(character);
            await characterRepository.SaveChangesAsync();

            return new CharacterDto
            {
                Id = character.Id,
                Name = character.Name,
                Class = character.Class,
                Level = character.Level
            };
        }

        public async Task<CharacterDto> GetCharacterByIdAsync(Guid characterId)
        {
            var character = await characterRepository.GetBydIdAsync(characterId) ?? throw new NotFoundException("Character not found");

            return new CharacterDto
            {
                Id = character.Id,
                Name = character.Name,
                Class = character.Class,
                Level = character.Level
            };
        }
    }
}
