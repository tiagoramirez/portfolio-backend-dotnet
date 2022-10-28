using Microsoft.AspNetCore.Mvc;
using portfolio.Auth.Services;
using portfolio.Helpers;
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
        return BadRequest(new { msg = "Invalid Credentials" });
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] User user)
    {
        ServiceStateType state = await _authService.RegisterAsync(user);

        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Registered" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}