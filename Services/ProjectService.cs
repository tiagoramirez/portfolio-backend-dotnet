using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IProjectService
{
    Task<ServiceStateType> CreateAsync(Project project, Guid userId);
    Task<ServiceStateType> EditAsync(Project project, Guid projectId, Guid profileId);
    Task<ServiceStateType> DeleteAsync(Guid projectId);
}

public class ProjectService : IProjectService
{
    PortfolioContext _context;

    public ProjectService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(Project project, Guid userId)
    {
        User user = await _context.Users.Include(p => p.Profiles).FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null) return ServiceStateType.UserNotFound;

        project.Id = Guid.NewGuid();
        project.UserId = userId;

        Guid firstProfileId = user.Profiles.FirstOrDefault().Id;
        Project_Description projDesc = new Project_Description
        {
            Id = Guid.NewGuid(),
            ProfileId = firstProfileId,
            ProjectId = project.Id,
            Description = project.Description
        };

        try
        {
            await _context.Projects.AddAsync(project);
            await _context.ProjectDescriptions.AddAsync(projDesc);
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

    public async Task<ServiceStateType> EditAsync(Project project, Guid projectId, Guid profileId)
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