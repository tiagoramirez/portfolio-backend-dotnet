using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IProfileConfigService
{
    Task<ProfileConfig> CreateAsync();
    Task<ServiceStateType> UpdateAsync(ProfileConfig config, Guid id);
    Task<ServiceStateType> DeleteAsync(Guid id);
}

public class ProfileConfigService : IProfileConfigService
{

    PortfolioContext _context;

    public ProfileConfigService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ProfileConfig> CreateAsync()
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
        try
        {
            await _context.ProfileConfigs.AddAsync(newConfig);
            await _context.SaveChangesAsync();
            return newConfig;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid id)
    {
        ProfileConfig config = await _context.ProfileConfigs.FindAsync(id);
        if (config != null)
        {
            try
            {
                _context.ProfileConfigs.Remove(config);
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.ProfileConfigNotFound;
    }

    public async Task<ServiceStateType> UpdateAsync(ProfileConfig config, Guid id)
    {
        ProfileConfig configToUpdate = await _context.ProfileConfigs.FindAsync(id);
        if (configToUpdate != null)
        {
            configToUpdate.ShowBanner = config.ShowBanner;
            configToUpdate.ShowLocation = config.ShowLocation;
            configToUpdate.ShowPhone = config.ShowPhone;
            configToUpdate.ShowPhoto = config.ShowPhoto;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.ProfileConfigNotFound;
    }
}