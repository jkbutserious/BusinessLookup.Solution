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
    public ActionResult<IEnumerable<Shop>> Get(int? id, string name, string cuisine, int? phone)
    {
      var query = _db.Shops.AsQueryable();

      if (id != null)
      {
        query = query.Where(entry => entry.RestaurantId == id);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Cuisine == cuisine);
      }
      if (phone != null)
      {
        query = query.Where(entry => entry.PhoneNumber == phone);
      }

      return query.ToList();
    }
  }