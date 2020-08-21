using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLookup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace BusinessLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private BusinessLookupContext _db;

    public ShopsController(BusinessLookupContext db)
    {
      _db = db;
    }

    // GET api/shops
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get(int? id, string name, string type, uint? phone)
    {
      var query = _db.Shops.AsQueryable();

      if (id != null)
      {
        query = query.Where(entry => entry.ShopId == id);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      if (phone != null)
      {
        query = query.Where(entry => entry.PhoneNumber == phone);
      }

      return query.ToList();
    }

    // POST api/shops
    [Authorize]
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }

    // PUT api/shops/[ShopId]
    [Authorize]
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;
      _db.Entry(shop).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/shops/[ShopId]
    [Authorize]
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shopToRemove = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
      _db.Shops.Remove(shopToRemove);
      _db.SaveChanges();
    }
  }
}