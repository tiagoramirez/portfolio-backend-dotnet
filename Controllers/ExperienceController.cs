using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Controllers;

[Authorize]
[ApiController]
[Route("API/[controller]")]
public class ExperienceController : ControllerBase
{
    IExperienceService _experienceService;

    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ExperienceDto experience, [FromHeader] string authorization)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _experienceService.CreateAsync(experience, userId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Experience Created" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{experienceId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid experienceId)
    {
        ServiceStateType state = await _experienceService.DeleteAsync(experienceId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Experience Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("{experienceId}")]
    public async Task<IActionResult> Edit([FromBody] ExperienceDto experience, [FromRoute] Guid experienceId)
    {
        ServiceStateType state = await _experienceService.EditAsync(experience, experienceId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Experience Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}