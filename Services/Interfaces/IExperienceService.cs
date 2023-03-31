
using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IExperienceService
{
    Task<Guid?> CreateAsync(ExperienceDto experience, string authorization);
    Task<ServiceStateType> UpdateAsync(ExperienceDto experience, string authorization);
    Task<ServiceStateType> DeleteAsync(Guid experienceId, string authorization);
}