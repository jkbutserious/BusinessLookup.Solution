using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLookup.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Controllers
{
  [Route("api/[controller")]
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
    public ActionResult<IEnumerable<Shop>> Get(int? id, string name, string type, int? phone)
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
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }
  }
}