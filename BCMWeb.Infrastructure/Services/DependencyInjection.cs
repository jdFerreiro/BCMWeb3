using BCMWeb.Application.Interfaces;
using BCMWeb.Infrastructure.Interfaces;
using BCMWeb.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BCMWeb.Infrastructure.Services
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            // Se utiliza para todos la misma instancia
            services.AddSingleton<IUriService>(provider =>
            {
                var accesor = provider.GetRequiredService<IHttpContextAccessor>();
                var request = accesor.HttpContext.Request;
                var absoluteUri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(absoluteUri);
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(BaseRepository<>));

            return services;
        }
    }
}
