using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VentaCasas.Presenters;
using VentaCasas.Repository;
using VentaCasas.UseCases;

namespace VentaCasas.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddVentaCasasDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}
