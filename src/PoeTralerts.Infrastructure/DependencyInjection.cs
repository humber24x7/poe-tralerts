using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PoeTralerts.Application.Interfaces;

namespace PoeTralerts.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string dbPath)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite($"Filename={dbPath}"));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

            return services;
        }
    }
}