using LundSchoolLocations.Helper;
using LundSchoolLocations.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Extensions;

public static class BuilderExtension
{
    public static IServiceCollection AddConfig(
            this IServiceCollection services, IConfiguration config)
    {
        services.AddTransient<ILocationOperations, LocationOperations>();
        services.AddDbContext<SchoolContext>();

        return services;
    }

}
