using AutoMapper;
using Fidlle.Application.DTO;
using Fidlle.Application.Exceptions;
using Fidlle.Application.IRepositories;
using Fidlle.Application.Services.Interfaces;
using Fidlle.Domain.Entities;
using Fidlle.Domain.Interfaces;

namespace Fidlle.Application.Services.Implementations
{
    public class CharacterService(ICharacterRepository characterRepository, IUserRepository userRepository, IMapper mapper) : ICharacterService
    {
        public async Task<CharacterDetailsDto> CreateCharacterAsync(CreateCharacterDto createCharacterDto, Guid userId)
        {
            var user = await userRepository.GetUserByIdAsync(userId) ?? throw new NotFoundException("User not found");

            var character = mapper.Map<Character>(createCharacterDto);
            character.Id = Guid.NewGuid();
            character.UserId = userId;
            character.User = user;

            await characterRepository.AddAsync(character);
            await characterRepository.SaveChangesAsync();

            return mapper.Map<CharacterDetailsDto>(character);
        }

        public async Task<IEnumerable<CharacterListItemDto>> GetUserCharactersAsync(Guid userId)
        {
            var characters = await characterRepository.GetUserCharactersAsync(userId);

            return mapper.Map<IEnumerable<CharacterListItemDto>>(characters);
        }

        public async Task<CharacterDetailsDto> GetCharacterByIdAsync(Guid characterId)
        {
            var character = await characterRepository.GetBydIdAsync(characterId) ?? throw new NotFoundException("Character not found");

            return mapper.Map<CharacterDetailsDto>(character);
        }
    }
}
