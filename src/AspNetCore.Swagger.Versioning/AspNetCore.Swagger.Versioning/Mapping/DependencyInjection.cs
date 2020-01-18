using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AspNetCore.Swagger.Versioning.Mapping
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
