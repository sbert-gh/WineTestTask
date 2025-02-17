using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WineCatalog.Core.Interfaces;
using WineCatalog.Infrastructure.Repositories;

namespace WineCatalog.Infrastructure.DI;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<WineDbContext>();

        services.AddScoped<IWineRepository, WineRepository>();
        return services;
    }
}
