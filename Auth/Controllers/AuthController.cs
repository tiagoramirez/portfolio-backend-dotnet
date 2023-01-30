using Microsoft.AspNetCore.Mvc;
using portfolio.Auth.DTOs;
using portfolio.Auth.Services;
using portfolio.Helpers;

namespace portfolio.Auth.Controllers;

[ApiController]
[Route("API/[controller]")]
public class AuthController : ControllerBase
{
    IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto register)
    {
        ServiceStateType state = await _authService.RegisterAsync(register);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "User registered in Backend" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpGet("Registered")]
    public async Task<bool> IsRegistered([FromQuery] string email, [FromQuery] string id)
    {
        return await _authService.CheckRegistered(email, id);
    }
}