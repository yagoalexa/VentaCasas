using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaCasas.UseCasesPorts;
using VentaCasas.UseCases;
using VentaCasas.UseCases.Mappings;

namespace VentaCasas.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapping());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddTransient<ICreatePropertyInputPort, CreatePropertyInteractor>();
            services.AddTransient<IUpdatePropertyInputPort, UpdatePropertyInteractor>();
            services.AddTransient<IGetPropertiesInputPort, GetPropertiesInteractor>();
            services.AddTransient<IGetPropertyInputPort, GetPropertyInteractor>();
            services.AddTransient<ICreatePropertyImageInputPort, CreatePropertyImageInteractor>();
            services.AddTransient<IGetPropertyImagesInputPort, GetPropertyImagesInteractor>();
            services.AddTransient<ICreateOwnerInputPort, CreateOwnerInteractor>();
            return services;
        }
    }
}
