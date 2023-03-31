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
        return await _authService.CheckRegistered(email, id);
    }

    [HttpGet("Login")]
    public async Task<IActionResult> Login([FromQuery] string id, [FromQuery] string email, [FromQuery] string username)
    {
        ServiceStateType state = await _authService.CheckLogin(id, username, email);
        if (state == ServiceStateType.Ok) return Ok(_authService.GenerateToken(id, username));
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}