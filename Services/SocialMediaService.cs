using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface ISocialMediaService
{
    IEnumerable<SocialMedia> GetAll();
    Task<ServiceStateType> CreateAsync(User_SocialMedia socialMedia);
    Task<ServiceStateType> DeleteAsync(Guid id);
}

public class SocialMediaService : ISocialMediaService
{
    PortfolioContext _context;

    public SocialMediaService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(User_SocialMedia socialMedia)
    {
        try
        {
            await _context.User_SocialMedias.AddAsync(socialMedia);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid id)
    {
        User_SocialMedia socialMedia = await _context.User_SocialMedias.FindAsync(id);
        if (socialMedia == null) return ServiceStateType.SocialMediaNotFound;
        try
        {
            _context.User_SocialMedias.Remove(socialMedia);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public IEnumerable<SocialMedia> GetAll()
    {
        return _context.SocialMedias;
    }
}