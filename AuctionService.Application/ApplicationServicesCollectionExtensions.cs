using AuctionService.App.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionService.App;

public static class ApplicationServicesCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        /*services.AddSingleton<IRatingRepository, RatingRepository>();
        services.AddSingleton<IMovieRepository, MovieRepositoryDb>();
        services.AddSingleton<IMovieService, MovieService>();
        services.AddValidatorsFromAssemblyContaining<IApplicationMarker>(ServiceLifetime.Singleton);    // TODO: how this works?works*/
        return services;
    }
    public static IServiceCollection AddDatabase(this IServiceCollection services, 
        string connectionString)
    {
        services.AddDbContext<AuctionDbContext>(opt =>
        {
            opt.UseNpgsql(connectionString);
        });
        services.AddSingleton<DbInitializer>();
        
        return services;
    }
}