using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReferenceProject.Infrastructure.DbContexts;

namespace ReferenceProject.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, Action<DbContextOptionsBuilder>? optionsAction)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddDbContext<ApplicationDbContext>(optionsAction, ServiceLifetime.Scoped, ServiceLifetime.Singleton);

            return services;
        }
    }
}
