using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
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

    [HttpPut("{configId}")]
    public async Task<IActionResult> Update([FromBody] ProfileConfig config, [FromRoute] Guid configId)
    {
        ServiceStateType state = await _profileConfigService.UpdateAsync(config, configId);

        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Configuration Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}