using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Controllers;

[Authorize]
[ApiController]
[Route("API/[controller]")]
public class ProjectController : ControllerBase
{
    IProjectService _projectService;

    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ProjectDto project, [FromHeader] string authorization)
    {
        Guid? id = await _projectService.CreateAsync(project, authorization);
        if (id != null) return Ok(new { msg = "Project Created", id });
        return BadRequest(new { msg = ServiceState.GetMessage(ServiceStateType.INTERNAL_ERROR) });
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ProjectDto project, [FromHeader] string authorization)
    {
        ServiceStateType state = await _projectService.UpdateAsync(project, authorization);
        if (state == ServiceStateType.OK) return Ok(new { msg = "Project Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{projectId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid projectId, [FromHeader] string authorization)
    {
        ServiceStateType state = await _projectService.DeleteAsync(projectId, authorization);
        if (state == ServiceStateType.OK) return Ok(new { msg = "Project Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

}