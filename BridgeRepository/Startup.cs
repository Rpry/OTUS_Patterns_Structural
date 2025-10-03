using BridgeRepository.Repositories;
using BridgeRepository.Storages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BridgeRepository;

public class Startup
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        // В Startup.cs или Program.cs
        services.AddSingleton<IUserStorage>(serviceProvider => 
        {
            var storageType = configuration["StorageType"];
            return storageType switch
            {
                "Sql" => new SqlUserStorage(configuration.GetConnectionString("SqlConnection")),
                "Mongo" => new MongoUserStorage(configuration.GetConnectionString("MongoConnection")),
                _ => new SqlUserStorage(configuration.GetConnectionString("SqlConnection"))
            };
        });

        services.AddSingleton<UserRepository>(serviceProvider =>
        {
            var storage = serviceProvider.GetRequiredService<IUserStorage>();
            return bool.Parse(configuration["UseCaching"]) 
                ? new CachingUserRepository(storage) 
                : new StandardUserRepository(storage);
        });

        services.AddScoped<UserService>();
    }
}