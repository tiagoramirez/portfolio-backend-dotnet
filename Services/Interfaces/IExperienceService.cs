using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IExperienceService
{
    Task<ServiceStateType> CreateAsync(ExperienceDto experience, string userId);
    Task<ServiceStateType> EditAsync(ExperienceDto experience, Guid experienceId);
    Task<ServiceStateType> DeleteAsync(Guid experienceId);
}