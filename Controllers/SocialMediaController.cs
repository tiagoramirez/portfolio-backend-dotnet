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

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SocialMediaDto socialMedia, [FromHeader] string authorization)
    {
        string userId = JwtHelper.GetId(authorization);
        ServiceStateType state = await _socialMediaService.CreateAsync(socialMedia, userId);
        if (state == ServiceStateType.Ok)
        {
            return Ok(new { msg = "Social Media Created" });
        }
        return BadRequest(new { msg = ServiceState.GetMessage(state) });
    }

    [Authorize]
    [HttpPut("{socialMediaId}")]
    public async Task<IActionResult> Update([FromBody] SocialMediaDto socialMedia, [FromRoute] Guid socialMediaId)
    {
        ServiceStateType state = await _socialMediaService.UpdateAsync(socialMedia, socialMediaId);
        if (state == ServiceStateType.Ok) return Ok(new { msg = "Social Media Updated" });
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