using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.DTOs;
using portfolio.Helpers;
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
        UserDto user = await _userService.GetByUsernameAsync(username);
        if (user == null)
        {
            return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.UserNotFound) });
        }
        await _userService.LoadDescriptionsAsync(user);
        return Ok(user);
    }

    [HttpGet("{username}/{profileId}")]
    public async Task<IActionResult> GetUserInfo(string username, Guid profileId)
    {
        UserDto user = await _userService.GetByUsernameAsync(username);
        if (user == null)
        {
            return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.UserNotFound) });
        }
        await _userService.LoadDescriptionsAsync(user, profileId);
        return Ok(user);
    }

    [Authorize]
    [HttpPut("UpdateName/{name}")]
    public async Task<IActionResult> UpdateName([FromHeader] string authorization, [FromRoute] string name)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _userService.UpdateNameAsync(userId, name);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Name Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpPut("UpdateUsername/{username}")]
    public async Task<IActionResult> UpdateUsername([FromHeader] string authorization, [FromRoute] string username)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _userService.UpdateUsernameAsync(userId, username);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Username Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpPut("UpdatePassword/{password}")]
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
    [HttpPut("UpdateEmail/{email}")]
    public async Task<IActionResult> UpdateEmail([FromHeader] string authorization, [FromRoute] string email)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _userService.UpdateEmailAsync(userId, email);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Email Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{userId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid userId, [FromHeader] string authorization)
    {
        Guid userId2 = JwtHelper.GetId(authorization);
        if (userId2 != userId) return BadRequest("Usuario invalido. Intenta de nuevo mas tarde...");
        ServiceStateType state = await _userService.DeleteAsync(userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}