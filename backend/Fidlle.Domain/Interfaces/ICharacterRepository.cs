using Fidlle.Domain.Entities;

namespace Fidlle.Domain.Interfaces
{
    public interface ICharacterRepository
    {
        Task AddAsync(Character character);
        Task<Character?> GetBydIdAsync(Guid characterId);
        Task<IEnumerable<Character>> GetUserCharactersAsync(Guid userId);
        Task SaveChangesAsync();
    }
}
