using Microsoft.AspNetCore.Mvc;
using portfolio.Auth.DTOs;
using portfolio.Auth.Services;
using portfolio.Helpers;

namespace portfolio.Auth.Controllers;

[ApiController]
[Route("API/[controller]")]
public class RegisterController : ControllerBase
{
    IRegisterService _registerService;

    public RegisterController(IRegisterService registerService)
    {
        _registerService = registerService;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterDto register)
    {
        ServiceStateType state = await _registerService.RegisterAsync(register);

        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Registered" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}