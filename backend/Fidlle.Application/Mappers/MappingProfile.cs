using AutoMapper;
using Fidlle.Application.DTO;
using Fidlle.Domain.Entities;

namespace Fidlle.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Character, CharacterDetailsDto>();
            CreateMap<Character, CharacterListItemDto>();
            CreateMap<CreateCharacterDto, Character>();
            CreateMap<RegisterDto, User>();
        }
    }
}
