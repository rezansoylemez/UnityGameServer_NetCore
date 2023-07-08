using Application.Repositories;
using Core.Persistence.DbContext;
using Core.Persistence.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        
        //services.Configure<DataBaseSettings>(options =>
        //{
        //    options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
        //    options.DatabaseName = Configuration.GetSection("MongoConnection:DatabaseName").Value;
        //});
        //services.AddDbContext<BaseDbContext>(
        //options => options.UseSqlServer(configuration.GetConnectionString("FrostlineGamesWebConnection")
        //)); 
         
        services.AddScoped<IPlayerRepository, PlayerRepository>();
        



        return services;
    }
}