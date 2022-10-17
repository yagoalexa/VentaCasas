using Microsoft.Extensions.DependencyInjection;
using VentaCasas.UseCasesPorts;

namespace VentaCasas.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreatePropertyImageOutputPort, CreatePropertyImagePresenter>();
            services.AddScoped<ICreatePropertyOutputPort, CreatePropertyPresenter>();
            services.AddScoped<ICreateOwnerOutputPort, CreateOwnerPresenter>();
            services.AddScoped<IGetPropertiesOutputPort, GetPropertiesPresenter>();
            services.AddScoped<IGetPropertyImagesOutputPort, GetPropertyImagesPresenter>();
            services.AddScoped<IUpdatePropertyOutputPort, UpdatePropertyPresenter>();
            services.AddScoped<IGetPropertyOutputPort, GetPropertyPresenter>();
            return services;
        }
    }
}
