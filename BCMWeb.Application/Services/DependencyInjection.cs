using BCMWeb.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BCMWeb.Application.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
