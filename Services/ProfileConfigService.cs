using portfolio.Models;

namespace portfolio.Services;

public interface IProfileConfigService
{
    Task<ProfileConfig> Create();
    Task<bool> Edit(ProfileConfig config, Guid id);
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

    public async Task<bool> Edit(ProfileConfig config, Guid id)
    {
        ProfileConfig configToEdit = await _context.ProfileConfigs.FindAsync(id);
        System.Console.WriteLine("entra aca");
        if (configToEdit != null)
        {
            configToEdit.ShowBanner = config.ShowBanner;
            configToEdit.ShowLocation = config.ShowLocation;
            configToEdit.ShowPhone = config.ShowPhone;
            configToEdit.ShowPhoto = config.ShowPhoto;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}