using LundSchoolLocations.Helper;
using LundSchoolLocations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChargingStationsSweden.Extensions;

public static class BuilderExtension
{
    public static IServiceCollection AddConfig(
            this IServiceCollection services, IConfiguration config)
    {
        services.AddTransient<ILocationOperations, LocationOperations>();
        services.AddDbContext<SchoolContext>(dbbuilder=>dbbuilder.UseSqlServer(config.GetConnectionString("DefaultConnection")));

        return services;
    }

}
