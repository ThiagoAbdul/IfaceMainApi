using IfaceMainApi.Repositories;
using IfaceMainApi.Services;
using IfaceMainApi.src.Repositories;
using IfaceMainApi.src.Services;

namespace IfaceMainApi.Configurations;
public static class DependencyInjection
{
     public static void InjectDependecies(this IServiceCollection services, IConfiguration configuration)
     {

        services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        services.AddScoped<CaregiverService>();
        services.AddScoped<PwadService>();

    }
}
