using Fidlle.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fidlle.Infrastructure.DbContexts
{
    public class QuestsContext(DbContextOptions<QuestsContext> options) : DbContext(options)
    {
        public DbSet<Trader> Traders { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<TraderQuest> TraderQuests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
