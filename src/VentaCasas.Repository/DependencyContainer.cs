using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VentaCasas.Entities.Interfaces;
using VentaCasas.Repository.DataContext;
using VentaCasas.Repository.Repositories;

namespace VentaCasas.Repository
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VentaCasasContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("VentaCasas")) 
            );
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IPropertyImageRepository, PropertyImageRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
