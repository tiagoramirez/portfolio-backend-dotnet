using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
using portfolio.Services;

namespace portfolio.Controllers;

[Authorize]
[ApiController]
[Route("API/[controller]")]
public class ProfileController : ControllerBase
{
    IProfileService _profileService;

    public ProfileController(IProfileService profileService)
    {
        _profileService = profileService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromHeader] string authorization)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _profileService.CreateAsync(userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Profile Created" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("{profileId}")]
    public async Task<IActionResult> Update([FromBody] ProfileDto profile, [FromRoute] Guid profileId)
    {
        ServiceStateType state = await _profileService.UpdateAsync(profile, profileId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Profile Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{profileId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid profileId)
    {
        ServiceStateType state = await _profileService.DeleteAsync(profileId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Profile Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}