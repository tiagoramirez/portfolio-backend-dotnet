using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface ISocialMediaService
{
    IEnumerable<SocialMediaDto> GetAll();
    Task<ServiceStateType> CreateAsync(User_SocialMediaDto socialMedia, string userId);
    Task<ServiceStateType> DeleteAsync(Guid id);
}