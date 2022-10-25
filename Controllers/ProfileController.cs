using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("Api/[controller]")]
public class ProfileController : ControllerBase
{
    IProfileService _profileService;

    public ProfileController(IProfileService profileService)
    {
        _profileService = profileService;
    }

    [HttpPost("Create/{userId}")]
    public async Task<IActionResult> Create([FromRoute] Guid userId)
    {
        await _profileService.Create(userId);
        return Ok(new { msg = "Profile created" });
    }

    [HttpPut("Update/{id}")]
    public async Task<IActionResult> Update([FromBody] Profile profile, [FromRoute] Guid id)
    {
        if (await _profileService.Update(profile, id))
        {
            return Ok(new { msg = "Profile updated" });
        }
        return BadRequest(new { msg = "Error. Profile not updated" });
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (await _profileService.Delete(id))
        {
            return Ok(new { msg = "Profile deleted" });
        }
        return BadRequest(new { msg = "User cannot have 0 profiles!" });
    }
}