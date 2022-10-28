using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
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
        User user = await _userService.GetByUsernameAsync(username);
        if (user == null)
        {
            return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.UserNotFound) });
        }
        return Ok(user);
    }

    [HttpPut("UpdateName/{id}/{name}")]
    public async Task<IActionResult> UpdateName([FromRoute] Guid id, [FromRoute] string name)
    {
        ServiceStateType state = await _userService.UpdateNameAsync(id, name);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Name Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("UpdateUsername/{id}/{username}")]
    public async Task<IActionResult> UpdateUsername([FromRoute] Guid id, [FromRoute] string username)
    {
        ServiceStateType state = await _userService.UpdateUsernameAsync(id, username);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Username Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("UpdatePassword/{id}/{password}")]
    public async Task<IActionResult> UpdatePassword([FromRoute] Guid id, [FromRoute] string password)
    {
        ServiceStateType state = await _userService.UpdatePasswordAsync(id, password);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Password Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("UpdateEmail/{id}/{email}")]
    public async Task<IActionResult> UpdateEmail([FromRoute] Guid id, [FromRoute] string email)
    {
        ServiceStateType state = await _userService.UpdateEmailAsync(id, email);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Email Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        ServiceStateType state = await _userService.DeleteAsync(id);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}