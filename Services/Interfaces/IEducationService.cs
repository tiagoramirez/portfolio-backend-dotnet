using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IEducationService
{
    Task<Guid?> CreateAsync(EducationDto education, string userId);
    Task<ServiceStateType> EditAsync(EducationDto education, Guid educationId);
    Task<ServiceStateType> DeleteAsync(Guid educationId);

}