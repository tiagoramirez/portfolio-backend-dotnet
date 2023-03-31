using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface ISocialMediaService
{
    Task<Guid?> CreateAsync(SocialMediaDto socialMedia, string authorization);
    Task<ServiceStateType> UpdateAsync(SocialMediaDto socialMedia, string authorization);
    Task<ServiceStateType> DeleteAsync(Guid id, string authorization);
}