using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("{username}/{password}")]
    public async Task<IActionResult> Login([FromRoute] string username, [FromRoute] string password)
    {
        ServiceStateType state = await _loginService.LoginAsync(username, password);
        if (state == ServiceStateType.Ok)
        {
            string token = await _loginService.GenerateToken(username);
            return Ok(new { tokenLogin = token });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}