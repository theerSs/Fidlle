using Fidlle.Domain.Entities;
using Fidlle.Domain.Interfaces;
using Fidlle.Infrastructure.DbContexts;

namespace Fidlle.Infrastructure.Repositories
{
    public class CharacterRepository(AppDbContext context) : ICharacterRepository
    {
        public async Task AddAsync(Character character)
        {
            await context.AddAsync(character);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
