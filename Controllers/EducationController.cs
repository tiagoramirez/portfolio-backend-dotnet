using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("API/[controller]")]
public class EducationController : ControllerBase
{
    IEducationService _educationService;

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    [HttpPost("{userId}")]
    public async Task<IActionResult> Create([FromBody] Education education, [FromRoute] Guid userId)
    {
        ServiceStateType state = await _educationService.CreateAsync(education, userId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Education Created" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{educationId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid educationId)
    {
        ServiceStateType state = await _educationService.DeleteAsync(educationId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Education Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("{educationId}/{profileId}")]
    public async Task<IActionResult> Edit([FromBody] Education education, [FromRoute] Guid educationId, [FromRoute] Guid profileId)
    {
        ServiceStateType state = await _educationService.EditAsync(education, educationId, profileId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Education Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}