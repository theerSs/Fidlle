using Fidlle.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fidlle.Infrastructure.DbContexts
{
    public class ItemsContext(DbContextOptions<ItemsContext> options) : DbContext(options)
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<EquipmentSlot> EquipmentSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
