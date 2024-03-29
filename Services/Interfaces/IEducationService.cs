using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IEducationService
{
    Task<Guid?> CreateAsync(EducationDto education, string authorization);
    Task<ServiceStateType> UpdateAsync(EducationDto education, string authorization);
    Task<ServiceStateType> DeleteAsync(Guid educationId, string authorization);

}