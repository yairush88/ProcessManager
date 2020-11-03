using Microsoft.Extensions.DependencyInjection;
using ProcessService;

namespace RestAPI
{
    public static class ServiceExtensions
    {
        public static void ConfigureWCFServices(this IServiceCollection services) =>
            services.AddScoped<IProcessService, ProcessServiceClient>();
    }
}
