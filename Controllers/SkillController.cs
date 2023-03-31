namespace portfolio.Controllers;

[ApiController]
[Route("API/[controller]")]
public class SkillController : ControllerBase
{
    ISkillService _skillService;

    public SkillController(ISkillService skillService)
    {
        _skillService = skillService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _skillService.GetAllAsync());
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User_SkillDto skill, [FromHeader] string authorization)
    {
        string userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _skillService.CreateAsync(skill, userId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Skill Created" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpPut("{skillId}")]
    public async Task<IActionResult> Update([FromBody] User_SkillDto skill, [FromRoute] Guid skillId)
    {
        ServiceStateType state = await _skillService.UpdateAsync(skill, skillId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Skill Updated" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{skillId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid skillId)
    {
        var state = await _skillService.DeleteAsync(skillId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Skill Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}