using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models.DTOs;
using portfolio.Helpers;
using portfolio.Services.Interfaces;

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
    public async Task<IActionResult> GetAllUsers([FromQuery] int count, [FromQuery] string email, [FromQuery] Guid id)
    {
        if (count == 1)
        {
            return Ok(await _userService.GetTotalUsersAsync());
        }
        if (email != null)
        {
            string username = await _userService.GetUsernameByIdEmailAsync(id, email);
            if (username == null) return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.IncorrectEmailIdCombination) });
            return Ok(username);
        }
        return Ok(await _userService.GetAllAsync());
    }

    [HttpGet("{username}")]
    public async Task<IActionResult> GetUserInfo(string username)
    {
        UserDto user = await _userService.GetByUsernameAsync(username);
        if (user == null)
        {
            return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.UserNotFound) });
        }
        return Ok(user);
    }

    [Authorize]
    [HttpPut]
    public async Task<IActionResult> UpdateName([FromHeader] string authorization, [FromBody] UserDto user)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _userService.UpdateUserAsync(userId, user);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpPut("Password/{password}")]
    public async Task<IActionResult> UpdatePassword([FromHeader] string authorization, [FromRoute] string password)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _userService.UpdatePasswordAsync(userId, password);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Password Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{userId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid userId, [FromHeader] string authorization)
    {
        Guid userId2 = JwtHelper.GetId(authorization);
        if (userId2 != userId) return BadRequest("Invalid user. Try again later...");
        ServiceStateType state = await _userService.DeleteUserAsync(userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}