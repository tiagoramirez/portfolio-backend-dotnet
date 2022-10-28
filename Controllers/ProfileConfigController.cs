using Microsoft.AspNetCore.Mvc;
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
        if (await _profileConfigService.UpdateAsync(config, id))
        {
            return Ok(new { msg = "Config updated" });
        }
        return BadRequest(new { msg = "Error. Config not updated" });
    }
}