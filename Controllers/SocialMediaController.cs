using Microsoft.AspNetCore.Mvc;
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
        return Ok(_socialMediaService.GetAllSocialMedia());
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User_SocialMedia socialMedia)
    {
        if (await _socialMediaService.CreateNewSocialMediaAsync(socialMedia))
        {
            return Ok(new { msg = "Social Media Created" });
        }
        return BadRequest(new { msg = "Social Media Not Created" });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        if (await _socialMediaService.DeleteSocialMediaAsync(id))
        {
            return Ok(new { msg = "Social Media Deleted" });
        }
        return BadRequest(new { msg = "Social Media Not Deleted" });
    }

}