using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("API/[controller]")]
public class ProfileConfigController : ControllerBase
{
    IProfileConfigService _profileConfigService;

    public ProfileConfigController(IProfileConfigService profileConfigService)
    {
        _profileConfigService = profileConfigService;
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit([FromBody] ProfileConfig config, [FromRoute] Guid id)
    {
        if (await _profileConfigService.Edit(config, id))
        {
            return Ok(new { msg = "Config updated" });
        }
        return BadRequest(new { msg = "Error. Config not updated" });
    }
}