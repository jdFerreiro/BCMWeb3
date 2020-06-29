using BCMWeb.Application.Interfaces;
using BCMWeb.Application.Services;
using BCMWeb.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BCMWeb.Infrastructure.Services
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserService, UserService>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(BaseRepository<>));

            return services;
        }
    }
}
