using Microsoft.AspNetCore.Mvc;
using portfolio.Auth.DTOs;
using portfolio.Auth.Services;
using portfolio.Helpers;

namespace portfolio.Auth.Controllers;

[ApiController]
[Route("API/[controller]")]
public class LoginController : ControllerBase
{
    ILoginService _loginService;

    public LoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginDto login)
    {
        ServiceStateType state = await _loginService.LoginAsync(login);
        if (state == ServiceStateType.Ok)
        {
            string token = await _loginService.GenerateToken(login);
            return Ok(new { tokenLogin = token });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}