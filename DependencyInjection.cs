using Microsoft.Extensions.DependencyInjection;
using Sayeed.Generic.OnionArchitecture.Controller;
using Sayeed.Generic.OnionArchitecture.Logic;
using Sayeed.Generic.OnionArchitecture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeed.Generic.OnionArchitecture;

public static class DependencyInjection
{
    public static IServiceCollection RegisterGenericControllerLayer(this IServiceCollection services)
    {
        return services.AddScoped(typeof(IBaseController<>), typeof(BaseController<>));
    }

    public static IServiceCollection RegisterGenericLogicLayer(this IServiceCollection services)
    {
        return services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

    }

    public static IServiceCollection RegisterGenericRepositoryLayer(this IServiceCollection services)
    {
        return services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
    }
}
