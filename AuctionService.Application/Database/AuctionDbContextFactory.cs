using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AuctionService.App.Database;

public class AuctionDbContextFactory : IDesignTimeDbContextFactory<AuctionDbContext>
{
    public AuctionDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AuctionDbContext>();
        optionsBuilder.UseNpgsql("Server=localhost:5432;User Id=postgres;Password=postgrespw;Database=auctions");
        
        return new AuctionDbContext(optionsBuilder.Options);
    }
}