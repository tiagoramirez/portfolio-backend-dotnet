using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IProfileService
{
    Task<ServiceStateType> CreateAsync(Guid userId);
    Task<ServiceStateType> UpdateAsync(Profile profile, Guid id);
    Task<ServiceStateType> DeleteAsync(Guid id);
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

    public async Task<ServiceStateType> CreateAsync(Guid userId)
    {
        ProfileConfig config = await _profileConfigService.CreateAsync();
        if (config == null) return ServiceStateType.ProfileConfigNotFound;

        Profile profile = new Profile
        {
            Id = Guid.NewGuid(),
            ProfileConfigId = config.Id,
            UserId = userId,
            Description = "",
            AboutMe = "",
        };
        try
        {
            await _context.Profiles.AddAsync(profile);
            await _context.SaveChangesAsync();
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }

        config.ProfileId = profile.Id;
        if (await _profileConfigService.UpdateAsync(config, config.Id) == ServiceStateType.Ok)
        {
            return ServiceStateType.Ok;
        }
        return ServiceStateType.InternalError;
    }

    public async Task<ServiceStateType> DeleteAsync(Guid id)
    {
        Profile profile = await _context.Profiles.FindAsync(id);
        if (profile == null) return ServiceStateType.ProfileNotFound;
        IEnumerable<Profile> userProfiles = _context.Profiles.Where(p => p.UserId == profile.UserId);
        if (userProfiles.Count() > 1)
        {
            try
            {
                // NOT NECESSARY BECAUSE CASCADE DELETE
                // _context.Profiles.Remove(profile);
                // await _context.SaveChangesAsync();
                await _profileConfigService.DeleteAsync(profile.ProfileConfigId);
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.OneProfileRequired;
    }

    public async Task<ServiceStateType> UpdateAsync(Profile profile, Guid id)
    {
        Profile profileToUpdate = await _context.Profiles.FindAsync(id);
        if (profileToUpdate != null)
        {
            profileToUpdate.Description = profile.Description;
            profileToUpdate.Phone = profile.Phone;
            profileToUpdate.LocationState = profile.LocationState;
            profileToUpdate.LocationCountry = profile.LocationCountry;
            profileToUpdate.AboutMe = profile.AboutMe;
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
        return ServiceStateType.ProfileNotFound;
    }
}