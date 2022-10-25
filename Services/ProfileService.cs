using portfolio.Models;

namespace portfolio.Services;

public interface IProfileService
{
    Task Create(Guid userId);
    Task<bool> Update(Profile profile, Guid id);
    Task<bool> Delete(Guid id);
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

        Profile profile = new Profile
        {
            Id = Guid.NewGuid(),
            ProfileConfigId = config.Id,
            UserId = userId,
            Description = "",
            AboutMe = "",
        };
        _context.Profiles.Add(profile);
        await _context.SaveChangesAsync();

        config.ProfileId = profile.Id;
        await _profileConfigService.Update(config, config.Id);
    }

    public async Task<bool> Delete(Guid id)
    {
        Profile profile = await _context.Profiles.FindAsync(id);
        IEnumerable<Profile> userProfiles = _context.Profiles.Where(p => p.UserId == profile.UserId);
        if (userProfiles.Count() > 1)
        {
            await _profileConfigService.Delete(profile.ProfileConfigId);
            // NOT NECESSARY BECAUSE CASCADE DELETE
            // _context.Profiles.Remove(profile);
            // await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> Update(Profile profile, Guid id)
    {
        Profile profileToUpdate = await _context.Profiles.FindAsync(id);
        if (profileToUpdate != null)
        {
            profileToUpdate.Description = profile.Description;
            profileToUpdate.Phone = profile.Phone;
            profileToUpdate.LocationState = profile.LocationState;
            profileToUpdate.LocationCountry = profile.LocationCountry;
            profileToUpdate.AboutMe = profile.AboutMe;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}