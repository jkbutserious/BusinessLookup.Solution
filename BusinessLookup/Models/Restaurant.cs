using System;

namespace BusinessLookup.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Cuisine { get; set; }
    public uint PhoneNumber { get; set; }
  }
}