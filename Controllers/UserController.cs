using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("/API/[controller]")]
public class UserController : ControllerBase
{
    IUserService _userService;

    public UserController(IUserService service)
    {
        _userService = service;
    }

    [HttpGet("Login/{username}/{password}")]
    public IActionResult Get([FromRoute] string username, [FromRoute] string password)
    {
        string token = _userService.Login(username, password);
        if (token != "")
        {
            return Ok(new { tokenLogin = token });
        }
        return BadRequest(new { msg = "Invalid username or password" });
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        System.Console.WriteLine($"Usuario disponible: {_userService.UsernameAvailable(user.Username)}");
        System.Console.WriteLine($"Mail disponible: {_userService.EmailAvailable(user.Email)}");
        if (_userService.UsernameAvailable(user.Username) && _userService.EmailAvailable(user.Email))
        {
            await _userService.Register(user);
            return Ok(new { msg = "User registered" });
        }
        return BadRequest(new { msg = "Username or email already in use" });
    }

    [HttpPut("Edit/Name/{id}/{name}")]
    public async Task<IActionResult> PutName([FromRoute] Guid id, [FromRoute] string name)
    {
        if (await _userService.EditName(name, id))
        {
            return Ok(new { msg = "Name edited" });
        }
        return BadRequest(new { msg = "User not found" });
    }

    [HttpPut("Edit/Username/{id}/{username}")]
    public async Task<IActionResult> PutUsername([FromRoute] Guid id, [FromRoute] string username)
    {
        if (await _userService.EditUsername(username, id))
        {
            return Ok(new { msg = "Username edited" });
        }
        return BadRequest(new { msg = "User not found" });
    }

    [HttpPut("Edit/Password/{id}/{password}")]
    public async Task<IActionResult> PutPassword([FromRoute] Guid id, [FromRoute] string password)
    {
        if (await _userService.EditPassword(password, id))
        {
            return Ok(new { msg = "Password edited" });
        }
        return BadRequest(new { msg = "User not found" });
    }

    [HttpPut("Edit/Email/{id}/{email}")]
    public async Task<IActionResult> PutEmail([FromRoute] Guid id, [FromRoute] string email)
    {
        if (await _userService.EditEmail(email, id))
        {
            return Ok(new { msg = "Email edited" });
        }
        return BadRequest(new { msg = "User not found" });
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {

        if (await _userService.Delete(id))
        {
            return Ok(new { msg = "User deleted" });
        }
        return BadRequest(new { msg = "User not found" });
    }
}