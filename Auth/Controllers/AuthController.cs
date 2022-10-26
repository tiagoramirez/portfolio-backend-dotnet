using Microsoft.AspNetCore.Mvc;
using portfolio.Auth.Services;
using portfolio.Models;

namespace portfolio.Auth.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpGet("Login/{username}/{password}")]
    public IActionResult Login([FromRoute] string username, [FromRoute] string password)
    {
        string token = _authService.Login(username, password);
        if (token != null)
        {
            return Ok(new { tokenLogin = token });
        }
        return BadRequest(new { msg = "Invalid username or password" });
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] User user)
    {
        if (_authService.UsernameAvailable(user.Username) && _authService.EmailAvailable(user.Email))
        {
            if (await _authService.Register(user))
            {
                return Ok(new { msg = "User registered" });
            }
            return BadRequest(new { msg = "Server error. Can't register new user. Try again later..." });
        }
        return BadRequest(new { msg = "Username or email already in use" });
    }
}