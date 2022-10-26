using portfolio.Models;

namespace portfolio.Services;

public interface IProfileConfigService
{
    Task<ProfileConfig> Create();
    Task<bool> Update(ProfileConfig config, Guid id);
    Task<bool> Delete(Guid id);
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

    public async Task<bool> Delete(Guid id)
    {
        ProfileConfig config = await _context.ProfileConfigs.FindAsync(id);
        if (config != null)
        {
            _context.ProfileConfigs.Remove(config);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> Update(ProfileConfig config, Guid id)
    {
        ProfileConfig configToUpdate = await _context.ProfileConfigs.FindAsync(id);
        System.Console.WriteLine("entra aca");
        if (configToUpdate != null)
        {
            configToUpdate.ShowBanner = config.ShowBanner;
            configToUpdate.ShowLocation = config.ShowLocation;
            configToUpdate.ShowPhone = config.ShowPhone;
            configToUpdate.ShowPhoto = config.ShowPhoto;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}