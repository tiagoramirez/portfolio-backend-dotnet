using System.Text.RegularExpressions;
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
        var user = await _userService.GetUserInfoAsync(username);
        if (user == null)
        {
            return NotFound(new { msg = "User not found" });
        }
        return Ok(user);
    }

    [HttpPut("UpdateName/{id}/{name}")]
    public async Task<IActionResult> UpdateName([FromRoute] Guid id, [FromRoute] string name)
    {
        if (await _userService.UpdateNameAsync(name, id))
        {
            return Ok(new { msg = "Name Updated" });
        }
        return BadRequest(new { msg = "Name Not Updated" });
    }

    [HttpPut("UpdateUsername/{id}/{username}")]
    public async Task<IActionResult> UpdateUsername([FromRoute] Guid id, [FromRoute] string username)
    {
        if (await _userService.UpdateUsernameAsync(username, id))
        {
            return Ok(new { msg = "Username Updated" });
        }
        return BadRequest(new { msg = "Username Not Updated" });
    }

    [HttpPut("UpdatePassword/{id}/{password}")]
    public async Task<IActionResult> UpdatePassword([FromRoute] Guid id, [FromRoute] string password)
    {
        if (await _userService.UpdatePasswordAsync(password, id))
        {
            return Ok(new { msg = "Password Updated" });
        }

        return BadRequest(new { msg = "Password Not Updated" });
    }

    [HttpPut("UpdateEmail/{id}/{email}")]
    public async Task<IActionResult> UpdateEmail([FromRoute] Guid id, [FromRoute] string email)
    {
        if (await _userService.UpdateEmailAsync(email, id))
        {
            return Ok(new { msg = "Email Updated" });
        }
        return BadRequest(new { msg = "Email Not Updated" });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (await _userService.DeleteAsync(id))
        {
            return Ok(new { msg = "User deleted" });
        }
        return BadRequest(new { msg = "User not found" });
    }
}