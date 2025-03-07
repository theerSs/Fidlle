using Fidlle.Application.Interfaces;
using Fidlle.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fidlle.Application.DI
{
    public static class InfrastructureServicesDI
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IPasswordService, PasswordService>();
            return services;
        }
    }
}
