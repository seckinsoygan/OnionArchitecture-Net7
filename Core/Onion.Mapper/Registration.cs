using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Interfaces.AutoMapper;
using System.Reflection;

namespace Onion.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
