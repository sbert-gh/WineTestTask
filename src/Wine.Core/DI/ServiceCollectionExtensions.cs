using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using WineCatalog.Core.Models;
using WineCatalog.Core.Services;
using WineCatalog.Core.Validators;

namespace WineCatalog.Core.DI;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddScoped<WineService>();
        services.AddAutoMapper(typeof(WineMappingProfile));

        services.AddFluentValidationAutoValidation();
        services.AddScoped<IValidator<WineDto>, WineDtoValidator>();

        return services;
    }
}
