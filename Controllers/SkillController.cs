using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

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
    public IActionResult GetAll()
    {
        return Ok(_skillService.GetAll());
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] User_Skill skill, [FromHeader] string authorization)
    {
        Guid userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _skillService.CreateAsync(skill, userId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Skill Created" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{skillId}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] Guid skillId)
    {
        var state = await _skillService.DeleteAsync(skillId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Skill Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}