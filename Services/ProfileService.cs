using portfolio.Models;

namespace portfolio.Services;

public interface IProfileService
{
    Task Create(Guid userId);
}

public class ProfileService : IProfileService
{
    PortfolioContext _context;

    IProfileConfigService _profileConfigService;

    public ProfileService(PortfolioContext context, IProfileConfigService profileConfigService)
    {
        _context = context;
        _profileConfigService = profileConfigService;
    }

    public async Task Create(Guid userId)
    {
        ProfileConfig config = await _profileConfigService.Create();

        Profile newProfile = new Profile
        {
            Id = Guid.NewGuid(),
            ProfileConfigId = config.Id,
            UserId = userId,
            Description = "",
            AboutMe = "",
        };
        _context.Profiles.Add(newProfile);
        await _context.SaveChangesAsync();

        config.ProfileId = newProfile.Id;
        await _profileConfigService.Edit(config, config.Id);
    }
}