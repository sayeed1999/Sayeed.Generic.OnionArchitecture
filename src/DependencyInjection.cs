using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sayeed.Generic.OnionArchitecture.Controller;
using Sayeed.Generic.OnionArchitecture.Logic;
using Sayeed.Generic.OnionArchitecture.Repository;

namespace Sayeed.Generic.OnionArchitecture;

public static class DependencyInjection
{
    public static IServiceCollection RegisterSqlServer<T>(this IServiceCollection services, IConfiguration configuration)
        where T : DbContext
    {
        services.AddDbContext<T>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }

    public static IServiceCollection RegisterPostgreSql<T>(this IServiceCollection services, IConfiguration configuration)
        where T : DbContext
    {
        services.AddDbContext<T>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }

    public static IServiceCollection RegisterGenericRepositoryLayer(this IServiceCollection services)
    {
        return services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
    }

    public static IServiceCollection RegisterGenericLogicLayer(this IServiceCollection services)
    {
        return services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

    }
}
