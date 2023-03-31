using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

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
        return Ok(await _skillService.GetAllSkillsAsync());
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User_SkillDto skill, [FromHeader] string authorization)
    {
        Guid? id = await _skillService.CreateAsync(skill, authorization);
        if (id != null) return Ok(new { msg = "Skill Created", id });
        return BadRequest(new { msg = ServiceState.GetMessage(ServiceStateType.InternalError) });
    }

    [Authorize]
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] User_SkillDto skill, [FromHeader] string authorization)
    {
        ServiceStateType state = await _skillService.UpdateAsync(skill, authorization);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Skill Updated" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{skillId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid skillId, [FromHeader] string authorization)
    {
        var state = await _skillService.DeleteAsync(skillId, authorization);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Skill Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}