using Fidlle.Api.Middlewares;

namespace Fidlle.Api.DI
{
    public static class ApiDI
    {
        public static IServiceCollection AddApiLayer(this IServiceCollection services)
        {
            services.AddSession();
            services.AddExceptionHandler<ExceptionHandlerMiddleware>();
            services.AddAntiforgery();
            return services;
        }
    }
}
