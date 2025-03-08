using Microsoft.EntityFrameworkCore;
using Fidlle.Domain.Entities;

namespace Fidlle.Infrastructure.DbContexts
{
    public class CharactersContext(DbContextOptions<CharactersContext> options) : DbContext(options)
    {

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterSkill> CharacterSkills { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
