using Application.Services.PlayerService;
using Microsoft.Extensions.DependencyInjection; 
using System.Reflection;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddAutoMapper(Assembly.GetExecutingAssembly());
        //services.AddMediatR(Assembly.GetExecutingAssembly());
        //services.AddMemoryCache();

        //services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
     
        
       // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
        
        services.AddScoped<IPlayerService, PlayerManager>();


        return services;
    }
    public static IServiceCollection AddSubClassesOfType(this IServiceCollection services, Assembly assembly, Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (var item in types)
        {
            if (addWithLifeCycle == null)
            {
                services.AddScoped(item);
            }
            else
            {
                addWithLifeCycle(services, type);
            }
        }
        return services;
    }
}