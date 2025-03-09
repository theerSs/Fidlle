using Fidlle.Domain.Entities;

namespace Fidlle.Domain.Interfaces
{
    public interface ICharacterRepository
    {
        Task AddAsync(Character character);
        Task SaveChangesAsync();
    }
}
