using Microsoft.AspNetCore.Mvc;
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

    [HttpPost("{userId}")]
    public async Task<IActionResult> Create([FromRoute] Guid userId)
    {
        if (await _profileService.CreateAsync(userId))
        {
            return Ok(new { msg = "Profile created" });
        }
        return BadRequest(new { msg = "Server error. Profile not created. Try again later..." });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromBody] Profile profile, [FromRoute] Guid id)
    {
        if (await _profileService.UpdateAsync(profile, id))
        {
            return Ok(new { msg = "Profile updated" });
        }
        return BadRequest(new { msg = "Error. Profile not updated" });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (await _profileService.DeleteAsync(id))
        {
            return Ok(new { msg = "Profile deleted" });
        }
        return BadRequest(new { msg = "User cannot have 0 profiles!" });
    }
}