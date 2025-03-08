using Fidlle.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fidlle.Infrastructure.DI
{
    public static class DbContextDI
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UsersContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<CharactersContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<ItemsContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<QuestsContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<SkillsContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
