using System.Threading.Tasks;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  public class AccountController : BaseApiController
  {
    public AccountController()
    {
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserDto>> login(LoginDto loginDto)
    {
      return new UserDto
      {
        Username = "",
        Token = ""
      };
    }
  }
}