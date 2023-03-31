using Microsoft.EntityFrameworkCore;
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

    public async Task<Guid?> CreateAsync(SocialMediaDto socialMedia, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        SocialMedia socialMediaToDb = new SocialMedia(socialMedia, userId);

        try
        {
            await _context.Social_Medias.AddAsync(socialMediaToDb);
            await _context.SaveChangesAsync();
            return socialMediaToDb.Id;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid id, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        SocialMedia socialMedia = await _context.Social_Medias.FindAsync(id);
        if (socialMedia == null || socialMedia.UserId != userId) return ServiceStateType.SocialMediaNotFound;

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

    public async Task<ServiceStateType> UpdateAsync(SocialMediaDto socialMedia, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        SocialMedia sm = await _context.Social_Medias.FindAsync(socialMedia.Id);
        if (sm == null || sm.UserId != userId) return ServiceStateType.SocialMediaNotFound;

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