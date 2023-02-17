using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IProjectService
{
    Task<Guid?> CreateAsync(ProjectDto project, string userId);
    Task<ServiceStateType> EditAsync(ProjectDto project, Guid projectId);
    Task<ServiceStateType> DeleteAsync(Guid projectId);
}