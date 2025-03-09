using Fidlle.Domain.Entities;
using Fidlle.Domain.Interfaces;
using Fidlle.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Fidlle.Infrastructure.Repositories
{
    public class CharacterRepository(AppDbContext context) : ICharacterRepository
    {
        public async Task AddAsync(Character character)
        {
            await context.AddAsync(character);
        }
        public async Task<Character?> GetBydIdAsync(Guid characterId)
        {
            return await context.Characters.FirstOrDefaultAsync(c => c.Id == characterId);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
