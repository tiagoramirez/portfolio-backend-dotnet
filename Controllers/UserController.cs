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

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _userService.GetAllAsync());
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

    [HttpPut("UpdateName/{userId}/{name}")]
    public async Task<IActionResult> UpdateName([FromRoute] Guid userId, [FromRoute] string name)
    {
        ServiceStateType state = await _userService.UpdateNameAsync(userId, name);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Name Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("UpdateUsername/{userId}/{username}")]
    public async Task<IActionResult> UpdateUsername([FromRoute] Guid userId, [FromRoute] string username)
    {
        ServiceStateType state = await _userService.UpdateUsernameAsync(userId, username);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Username Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("UpdatePassword/{userId}/{password}")]
    public async Task<IActionResult> UpdatePassword([FromRoute] Guid userId, [FromRoute] string password)
    {
        ServiceStateType state = await _userService.UpdatePasswordAsync(userId, password);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Password Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("UpdateEmail/{userId}/{email}")]
    public async Task<IActionResult> UpdateEmail([FromRoute] Guid userId, [FromRoute] string email)
    {
        ServiceStateType state = await _userService.UpdateEmailAsync(userId, email);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Email Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{userId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid userId)
    {
        ServiceStateType state = await _userService.DeleteAsync(userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}