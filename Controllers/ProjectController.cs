using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("API/[controller]")]
public class ProjectController : ControllerBase
{
    IProjectService _projectService;

    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpPost("{userId}")]
    public async Task<IActionResult> Create([FromBody] Project project, [FromRoute] Guid userId)
    {
        ServiceStateType state = await _projectService.CreateAsync(project, userId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Project Created" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{projectId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid projectId)
    {
        ServiceStateType state = await _projectService.DeleteAsync(projectId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Project Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("{projectId}/{profileId}")]
    public async Task<IActionResult> Edit([FromBody] Project project, [FromRoute] Guid projectId, [FromRoute] Guid profileId)
    {
        ServiceStateType state = await _projectService.EditAsync(project, projectId, profileId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Project Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}