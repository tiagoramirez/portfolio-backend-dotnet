using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Controllers;

[Authorize]
[ApiController]
[Route("API/[controller]")]
public class EducationController : ControllerBase
{
    IEducationService _educationService;

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] EducationDto education, [FromHeader] string authorization)
    {
        string userId = JwtHelper.GetId(authorization);
        Guid? id = await _educationService.CreateAsync(education, userId);
        if (id != null) return Ok(new { msg = "Education Created", id });
        return BadRequest(new { msg = ServiceState.GetMessage(ServiceStateType.InternalError) });
    }

    [HttpDelete("{educationId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid educationId)
    {
        ServiceStateType state = await _educationService.DeleteAsync(educationId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Education Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("{educationId}")]
    public async Task<IActionResult> Edit([FromBody] EducationDto education, [FromRoute] Guid educationId)
    {
        ServiceStateType state = await _educationService.EditAsync(education, educationId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Education Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}