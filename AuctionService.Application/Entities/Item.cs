using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.App.Entities;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public required string Color { get; set; }
    public int Mileage { get; set; }
    public required string ImageUrl { get; set; }
    
    // nav(navigation) property to make 1-to-1 relation
    public Auction? Auction { get; set; }
    public Guid AuctionId { get; set; }
}