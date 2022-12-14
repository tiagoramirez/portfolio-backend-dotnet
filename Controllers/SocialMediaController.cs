using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Helpers;
using portfolio.Models.DTOs;
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
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User_SocialMediaDto socialMedia, [FromHeader] string authorization)
    {
        Guid userId = JwtHelper.GetId(authorization);
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