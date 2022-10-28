using portfolio.Models;

namespace portfolio.Services;

public interface IProfileService
{
    Task<bool> CreateAsync(Guid userId);
    Task<bool> UpdateAsync(Profile profile, Guid id);
    Task<bool> DeleteAsync(Guid id);
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

    public async Task<bool> CreateAsync(Guid userId)
    {
        ProfileConfig config = await _profileConfigService.CreateAsync();
        if (config == null) return false;

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
            return false;
        }

        config.ProfileId = profile.Id;
        return await _profileConfigService.UpdateAsync(config, config.Id);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        Profile profile = await _context.Profiles.FindAsync(id);
        if (profile == null) return false;
        IEnumerable<Profile> userProfiles = _context.Profiles.Where(p => p.UserId == profile.UserId);
        if (userProfiles.Count() > 1)
        {
            try
            {
                // NOT NECESSARY BECAUSE CASCADE DELETE
                // _context.Profiles.Remove(profile);
                // await _context.SaveChangesAsync();
                await _profileConfigService.DeleteAsync(profile.ProfileConfigId);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        return false;
    }

    public async Task<bool> UpdateAsync(Profile profile, Guid id)
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
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        return false;
    }
}