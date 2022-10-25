using portfolio.Models;

namespace portfolio.Services;

public interface IProfileConfigService
{
    Task<ProfileConfig> Create();
    Task Edit(ProfileConfig config, Guid id);
}

public class ProfileConfigService : IProfileConfigService
{

    PortfolioContext _context;

    public ProfileConfigService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ProfileConfig> Create()
    {
        ProfileConfig newConfig = new ProfileConfig
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.NewGuid(),//Not the final guid
            ShowPhoto = false,
            ShowBanner = false,
            ShowLocation = false,
            ShowPhone = false
        };
        _context.ProfileConfigs.Add(newConfig);
        await _context.SaveChangesAsync();
        return newConfig;
    }

    public Task Edit(ProfileConfig config, Guid id)
    {
        _context.ProfileConfigs.Update(config);
        return _context.SaveChangesAsync();
    }
}