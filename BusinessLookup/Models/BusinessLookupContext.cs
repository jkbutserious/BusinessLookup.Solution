using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
  public class BusinessLookupContext : DbContext
  {
    public BusinessLookupContext(DbContextOptions<BusinessLookupContext> options) : base(options)
    {
    }

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shop>()
        .HasData(
          new Shop { ShopId = 1, Name = "The Crevasse", Type = "Clothing", PhoneNumber = 4255550001 },
          new Shop { ShopId = 2, Name = "The Crisper Picture", Type = "Electronics", PhoneNumber = 4255550002 },
          new Shop { ShopId = 3, Name = "Farmhouse and Highborn", Type = "Book", PhoneNumber = 4255550003 },
          new Shop { ShopId = 4, Name = "QXNickel", Type = "Department Store", PhoneNumber = 4255550004 }
        );
    }
  }
}