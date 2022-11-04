using Microsoft.AspNetCore.Mvc;
using portfolio.Auth.Services;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Auth.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    IRegisterService _registerService;

    public AuthController(IRegisterService registerService)
    {
        _registerService = registerService;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] User user)
    {
        ServiceStateType state = await _registerService.RegisterAsync(user);

        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Registered" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}