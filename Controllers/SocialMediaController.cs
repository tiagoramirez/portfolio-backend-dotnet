using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

[ApiController]
[Route("API/[controller]")]
public class SocialMediaController : ControllerBase
{
    ISocialMediaService _socialMediaService;

    public SocialMediaController(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_socialMediaService.GetAll());
    }

    [Authorize]
    [HttpPost("{userId}")]
    public async Task<IActionResult> Create([FromBody] User_SocialMedia socialMedia, [FromRoute] Guid userId)
    {
        ServiceStateType state = await _socialMediaService.CreateAsync(socialMedia, userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Social Media Created" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpDelete("{socialMediaId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid socialMediaId)
    {
        ServiceStateType state = await _socialMediaService.DeleteAsync(socialMediaId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Social Media Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

}