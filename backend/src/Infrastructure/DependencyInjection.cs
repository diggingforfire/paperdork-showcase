using Application;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration) =>
        services.AddDatabase(configuration);


    private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PaperdorkDatabase");
        
        services.AddDbContext<PaperdorkContext>(options => 
            options.UseSqlServer(connectionString));

        services.AddScoped<IPaperdorkContext>(sp => sp.GetRequiredService<PaperdorkContext>());
        return services;
    }
}
