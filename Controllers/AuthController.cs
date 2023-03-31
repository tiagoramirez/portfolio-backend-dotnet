using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Controllers;

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
        return await _authService.isRegisteredAsync(email, id);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginDto login)
    {
        ServiceStateType state = await _authService.LoginAync(login);
        if (state == ServiceStateType.Ok) return Ok(_authService.GenerateToken(login.Id, login.Username));
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}