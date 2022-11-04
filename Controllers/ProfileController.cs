using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("API/[controller]")]
public class ProfileController : ControllerBase
{
    IProfileService _profileService;

    public ProfileController(IProfileService profileService)
    {
        _profileService = profileService;
    }

    [Authorize]
    [HttpPost("{userId}")]
    public async Task<IActionResult> Create([FromRoute] Guid userId)
    {
        ServiceStateType state = await _profileService.CreateAsync(userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Profile Created" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpPut("{profileId}")]
    public async Task<IActionResult> Update([FromBody] Profile profile, [FromRoute] Guid profileId)
    {
        ServiceStateType state = await _profileService.UpdateAsync(profile, profileId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Profile Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
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