using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

public class SocialMediaService : ISocialMediaService
{
    PortfolioContext _context;

    public SocialMediaService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(SocialMediaDto socialMedia, string userId)
    {
        SocialMedia socialMediaToDb = new SocialMedia(socialMedia, userId);

        try
        {
            await _context.Social_Medias.AddAsync(socialMediaToDb);
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
        SocialMedia socialMedia = await _context.Social_Medias.FindAsync(id);
        if (socialMedia == null) return ServiceStateType.SocialMediaNotFound;
        try
        {
            _context.Social_Medias.Remove(socialMedia);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> UpdateAsync(SocialMediaDto socialMedia, Guid socialMediaId)
    {
        SocialMedia sm = await _context.Social_Medias.FindAsync(socialMediaId);
        if (sm == null) return ServiceStateType.SocialMediaNotFound;

        sm.Name = socialMedia.Name;
        sm.Url = socialMedia.Url;

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
}