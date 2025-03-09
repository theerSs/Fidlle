using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Fidlle.Application.DI
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddValidators();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
