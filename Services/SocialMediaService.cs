using portfolio.Models;

namespace portfolio.Services;

public interface ISocialMediaService
{
    IEnumerable<SocialMedia> GetAllSocialMediaAsync();
    Task<bool> CreateNewSocialMediaAsync(User_SocialMedia socialMedia);
    Task<bool> DeleteSocialMediaAsync(Guid id);
}

public class SocialMediaService : ISocialMediaService
{
    PortfolioContext _context;

    public SocialMediaService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateNewSocialMediaAsync(User_SocialMedia socialMedia)
    {
        try
        {
            await _context.User_SocialMedias.AddAsync(socialMedia);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteSocialMediaAsync(Guid id)
    {
        User_SocialMedia socialMedia = await _context.User_SocialMedias.FindAsync(id);
        if (socialMedia == null) return false;
        try
        {
            _context.User_SocialMedias.Remove(socialMedia);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    public IEnumerable<SocialMedia> GetAllSocialMediaAsync()
    {
        return _context.SocialMedias;
    }
}