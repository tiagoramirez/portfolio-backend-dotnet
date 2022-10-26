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

    [HttpGet("{username}")]
    public async Task<IActionResult> GetUserInfo(string username)
    {
        var user = await _userService.GetUserInfo(username);
        if (user == null)
        {
            return NotFound(new { msg = "User not found" });
        }
        return Ok(user);
    }

    [HttpPut("Update/Name/{id}/{name}")]
    public async Task<IActionResult> UpdateName([FromRoute] Guid id, [FromRoute] string name)
    {
        if (await _userService.UpdateName(name, id))
        {
            return Ok(new { msg = "Name Updateed" });
        }
        return BadRequest(new { msg = "User not found" });
    }

    [HttpPut("Update/Username/{id}/{username}")]
    public async Task<IActionResult> UpdateUsername([FromRoute] Guid id, [FromRoute] string username)
    {
        if (await _userService.UpdateUsername(username, id))
        {
            return Ok(new { msg = "Username Updateed" });
        }
        return BadRequest(new { msg = "User not found" });
    }

    [HttpPut("Update/Password/{id}/{password}")]
    public async Task<IActionResult> UpdatePassword([FromRoute] Guid id, [FromRoute] string password)
    {
        if (await _userService.UpdatePassword(password, id))
        {
            return Ok(new { msg = "Password Updateed" });
        }
        return BadRequest(new { msg = "User not found" });
    }

    [HttpPut("Update/Email/{id}/{email}")]
    public async Task<IActionResult> UpdateEmail([FromRoute] Guid id, [FromRoute] string email)
    {
        if (await _userService.UpdateEmail(email, id))
        {
            return Ok(new { msg = "Email Updateed" });
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