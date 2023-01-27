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

    [HttpPost("/Register")]
    public async Task<string> Register([FromBody] RegisterDto register)
    {
        return await _authService.RegisterAsync(register);
    }

    [HttpGet("/Registered")]
    public async Task<bool> IsRegistered([FromQuery] string username, [FromQuery] Guid id)
    {
        return await _authService.CheckRegistered(username, id);
    }
}