using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BusinessLookup.Services;
using BusinessLookup.Entities;

namespace BusinessLookup.Controllers
{
  [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
      private IUserService _userService;

      public UsersController(IUserService userService)
      {
        _userService = userService;
      }

      [AllowAnonymous]
      [HttpPost("authenticate")]
      public IActionResult Authenticate([FromBody]User userParam)
      {
        var user = _userService.Authenticate(userParam.UserName, userParam.Password);

        if (user == null)
        {
          return BadRequest(new { message = "Username or password is incorrect" });
        }

        return Ok(user);
      }

      // route /users
      [HttpGet]
      public IActionResult GetAll()
      {
        var users =  _userService.GetAll();
        return Ok(users);
      }
    }
}