using Fidlle.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Fidlle.Infrastructure.DbContexts
{
    public class UsersContext(DbContextOptions<UsersContext> options) : DbContext(options)
    {
       public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
