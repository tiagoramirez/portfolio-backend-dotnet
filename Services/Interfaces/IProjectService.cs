
using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IProjectService
{
    Task<Guid?> CreateAsync(ProjectDto project, string authorization);
    Task<ServiceStateType> UpdateAsync(ProjectDto project, string authorization);
    Task<ServiceStateType> DeleteAsync(Guid projectId, string authorization);
}