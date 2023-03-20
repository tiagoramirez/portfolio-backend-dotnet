using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
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
    public async Task<IActionResult> UsersInfo([FromQuery] int count, [FromQuery] string email, [FromQuery] string id, [FromQuery] string available)
    {
        if (count == 1)
        {
            return Ok(await _userService.GetTotalUsersAsync());
        }
        if (email != null && id != null)
        {
            string username = await _userService.GetUsernameByIdEmailAsync(id, email);
            if (username == null) return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.IncorrectEmailIdCombination) });
            return Ok(username);
        }
        if (available != null)
        {
            return Ok(await _userService.IsUsernameAvailable(available));
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
    public async Task<IActionResult> UpdateUser([FromHeader] string authorization, [FromBody] UserDto user)
    {
        string userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _userService.UpdateUserAsync(userId, user);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{userId}")]
    public async Task<IActionResult> Delete([FromRoute] string userId, [FromHeader] string authorization)
    {
        string userId2 = JwtHelper.GetId(authorization);
        if (userId2 != userId) return BadRequest("Invalid user. Try again later...");
        ServiceStateType state = await _userService.DeleteUserAsync(userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "User Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}