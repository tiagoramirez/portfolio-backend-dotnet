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
        string userId = JwtHelper.GetId(authorization);
        Guid? id = await _projectService.CreateAsync(project, userId);
        if (id != null) return Ok(new { msg = "Project Created", id });
        return BadRequest(new { msg = ServiceState.GetMessage(ServiceStateType.InternalError) });
    }

    [HttpDelete("{projectId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid projectId)
    {
        ServiceStateType state = await _projectService.DeleteAsync(projectId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Project Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpPut("{projectId}")]
    public async Task<IActionResult> Edit([FromBody] ProjectDto project, [FromRoute] Guid projectId)
    {
        ServiceStateType state = await _projectService.EditAsync(project, projectId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Project Edited" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}