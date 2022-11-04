using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("API/[controller]")]
public class ExperienceController : ControllerBase
{
    IExperienceService _experienceService;

    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    [Authorize]
    [HttpPost("{userId}")]
    public async Task<IActionResult> Create([FromBody] Experience experience, [FromRoute] Guid userId)
    {
        ServiceStateType state = await _experienceService.CreateAsync(experience, userId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Experience Created" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{experienceId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid experienceId)
    {
        ServiceStateType state = await _experienceService.DeleteAsync(experienceId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Experience Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpPut("{experienceId}/{profileId}")]
    public async Task<IActionResult> Edit([FromBody] Experience experience, [FromRoute] Guid experienceId, [FromRoute] Guid profileId)
    {
        ServiceStateType state = await _experienceService.EditAsync(experience, experienceId, profileId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Experience Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}