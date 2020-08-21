using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLookup.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Controllers
{
  [Route("api/[controller")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private BusinessLookupContext _db;
    
    public RestaurantsController(BusinessLookupContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get(int? id, string name, string cuisine, int? phone)
    {
      var query = _db.Restaurants.AsQueryable();

      if (id != null)
      {
        query = query.Where(entry => entry.RestaurantId == id);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (cuisine != null)
      {
        query = query.Where(entry => entry.Cuisine == cuisine);
      }
      if (phone != null)
      {
        query = query.Where(entry => entry.PhoneNumber == phone);
      }

      return query.ToList();
    }

    // POST api/shops
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    // PUT api/shops/[ShopId]
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }
  }