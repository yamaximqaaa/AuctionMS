using AuctionService.App.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.App.Database;

public class AuctionDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Auction> Auctions { get; set; }
}