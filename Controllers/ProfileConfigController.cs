using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("API/Config")]
public class ProfileConfigController : ControllerBase
{
    IProfileConfigService _profileConfigService;

    public ProfileConfigController(IProfileConfigService profileConfigService)
    {
        _profileConfigService = profileConfigService;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromBody] ProfileConfig config, [FromRoute] Guid id)
    {
        ServiceStateType state = await _profileConfigService.UpdateAsync(config, id);

        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Configuration Updated" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}