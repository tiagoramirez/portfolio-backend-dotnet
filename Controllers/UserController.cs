using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    IUserService _userService;

    public UserController(IUserService service)
    {
        _userService = service;
    }

    [HttpGet("/login/{username}/{password}")]
    public IActionResult Get([FromRoute] string username, [FromRoute] string password)
    {
        string token = _userService.Login(username, password);
        if (token != "")
        {
            return Ok(new { tokenLogin = token });
        }
        return BadRequest(new { msg = "Invalid username or password" });
    }

    [HttpPost("/register")]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        if (_userService.UsernameAvailable(user.Username) && _userService.EmailAvailable(user.Email))
        {
            await _userService.Register(user);
            return Ok(new { msg = "User registered" });
        }
        return BadRequest(new { msg = "Username or email already in use" });
    }
}