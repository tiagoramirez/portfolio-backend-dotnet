using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services;

namespace portfolio.Controllers;

[Authorize]
[ApiController]
[Route("API/Config")]
public class ProfileConfigController : ControllerBase
{
    IProfileConfigService _profileConfigService;

    public ProfileConfigController(IProfileConfigService profileConfigService)
    {
        _profileConfigService = profileConfigService;
    }

    [HttpPut("{profileId}")]
    public async Task<IActionResult> Update([FromBody] ProfileConfigDto config, [FromRoute] Guid profileId)
    {
        ServiceStateType state = await _profileConfigService.UpdateAsync(config, profileId);

        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Configuration Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}