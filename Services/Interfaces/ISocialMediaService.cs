using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface ISocialMediaService
{
    Task<ServiceStateType> CreateAsync(SocialMediaDto socialMedia, string userId);
    Task<ServiceStateType> DeleteAsync(Guid id);
    Task<ServiceStateType> UpdateAsync(SocialMediaDto socialMedia, Guid socialMediaId);
}