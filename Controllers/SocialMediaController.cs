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

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User_SocialMedia socialMedia)
    {
        ServiceStateType state = await _socialMediaService.CreateAsync(socialMedia);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Social Media Created" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        ServiceStateType state = await _socialMediaService.DeleteAsync(id);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Social Media Deleted" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

}