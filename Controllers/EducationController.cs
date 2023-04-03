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
        Guid? id = await _educationService.CreateAsync(education, authorization);
        if (id != null) return Ok(new { msg = "Education Created", id });
        return BadRequest(new { msg = ServiceState.GetMessage(ServiceStateType.INTERNAL_ERROR) });
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] EducationDto education, [FromHeader] string authorization)
    {
        ServiceStateType state = await _educationService.UpdateAsync(education, authorization);
        if (state == ServiceStateType.OK) return Ok(new { msg = "Education Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{educationId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid educationId, [FromHeader] string authorization)
    {
        ServiceStateType state = await _educationService.DeleteAsync(educationId, authorization);
        if (state == ServiceStateType.OK) return Ok(new { msg = "Education Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}