using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Controllers;

[Authorize]
[ApiController]
[Route("API/[controller]")]
public class SocialMediaController : ControllerBase
{
    ISocialMediaService _socialMediaService;

    public SocialMediaController(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SocialMediaDto socialMedia, [FromHeader] string authorization)
    {
        Guid? id = await _socialMediaService.CreateAsync(socialMedia, authorization);
        if (id != null) return Ok(new { msg = "Social Media Created", id });
        return BadRequest(new { msg = ServiceState.GetMessage(ServiceStateType.INTERNAL_ERROR) });

    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] SocialMediaDto socialMedia, [FromHeader] string authorization)
    {
        ServiceStateType state = await _socialMediaService.UpdateAsync(socialMedia, authorization);
        if (state == ServiceStateType.OK) return Ok(new { msg = "Social Media Updated" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{socialMediaId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid socialMediaId, [FromHeader] string authorization)
    {
        ServiceStateType state = await _socialMediaService.DeleteAsync(socialMediaId, authorization);
        if (state == ServiceStateType.OK) return Ok(new { msg = "Social Media Deleted" });
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }
}