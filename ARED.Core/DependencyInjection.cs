using ARED.Core.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ARED.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoreLayer(this IServiceCollection services)
        {
            services.AddSingleton<AREDContext>();
            services.AddTransient<DataSeed>();

            var serviceProvider = services.BuildServiceProvider();
            var dataSeed = serviceProvider.GetService<DataSeed>();
            dataSeed?.Initialize();

            return services;
        }
    }
}
