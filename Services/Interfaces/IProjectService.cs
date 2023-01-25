using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IProjectService
{
    Task<ServiceStateType> CreateAsync(ProjectDto project, Guid userId);
    Task<ServiceStateType> EditAsync(ProjectDto project, Guid projectId);
    Task<ServiceStateType> DeleteAsync(Guid projectId);
}