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

    [HttpGet("page")]
    public async Task<IActionResult> GetUsersByPage([FromQuery] int number)
    {
        return Ok(await _userService.GetAllUsersAsync(number));
    }

    [HttpGet("count")]
    public async Task<IActionResult> GetTotalUsers()
    {
        return Ok(await _userService.GetTotalUsersAsync());
    }

    [HttpGet("available")]
    public async Task<IActionResult> UsernameAvailable([FromQuery] string username)
    {
        return Ok(await _userService.IsUsernameAvailableAsync(username));
    }

    [HttpGet("username")]
    public async Task<IActionResult> GetUsername([FromQuery] string email, [FromQuery] string id)
    {
        string username = await _userService.GetUsernameByIdEmailAsync(id, email);
        if (username == null) return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.IncorrectEmailIdCombination) });
        return Ok(username);
    }

    [HttpGet("{username}")]
    public async Task<IActionResult> GetUserByUsername([FromRoute] string username)
    {
        UserDto user = await _userService.GetUserByUsernameAsync(username);
        if (user == null)
        {
            return NotFound(new { msg = ServiceState.GetMessage(ServiceStateType.UserNotFound) });
        }
        return Ok(user);
    }

    [Authorize]
    [HttpPut]
    public async Task<IActionResult> UpdateUser([FromBody] UserDto user, [FromHeader] string authorization)
    {
        ServiceStateType state = await _userService.UpdateUserAsync(user, authorization);
        if (state == ServiceStateType.Ok) { return Ok(new { msg = "User Updated" }); }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{userId}")]
    public async Task<IActionResult> Delete([FromHeader] string authorization)
    {
        ServiceStateType state = await _userService.DeleteUserAsync(authorization);
        if (state == ServiceStateType.Ok) { return Ok(new { msg = "User Deleted" }); }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}