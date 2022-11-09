using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;

namespace portfolio.Services;

public interface IProjectService
{
    Task<ServiceStateType> CreateAsync(ProjectDto project, Guid userId);
    Task<ServiceStateType> EditAsync(ProjectDto project, Guid projectId, Guid profileId);
    Task<ServiceStateType> DeleteAsync(Guid projectId);
}

public class ProjectService : IProjectService
{
    PortfolioContext _context;

    public ProjectService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(ProjectDto project, Guid userId)
    {
        User user = await _context.Users.Include(p => p.Profiles).FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null) return ServiceStateType.UserNotFound;

        Project projToDb = new(project, userId);

        try
        {
            await _context.Projects.AddAsync(projToDb);
            foreach (Profile profile in user.Profiles)
            {
                Project_Description projDesc = new Project_Description
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    ProjectId = projToDb.Id,
                    Description = project.Description
                };
                await _context.ProjectDescriptions.AddAsync(projDesc);
            }
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid projectId)
    {
        Project proj = await _context.Projects.FindAsync(projectId);
        if (proj == null) return ServiceStateType.ExperienceNotFound;

        try
        {
            _context.ProjectDescriptions.Where(pd => pd.ProjectId == projectId).ToList().ForEach(pd => _context.ProjectDescriptions.Remove(pd));
            _context.Projects.Remove(proj);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> EditAsync(ProjectDto project, Guid projectId, Guid profileId)
    {
        Project proj = await _context.Projects.FindAsync(projectId);
        if (proj == null) return ServiceStateType.ExperienceNotFound;
        proj.Name = project.Name;
        proj.Url = project.Url;
        try
        {
            Project_Description projDesc = await _context.ProjectDescriptions.FirstOrDefaultAsync(ed => ed.ProjectId == projectId && ed.ProfileId == profileId);
            projDesc.Description = project.Description;
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }
}