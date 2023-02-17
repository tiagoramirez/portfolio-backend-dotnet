using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

public class ProjectService : IProjectService
{
    PortfolioContext _context;

    public ProjectService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<Guid?> CreateAsync(ProjectDto project, string userId)
    {
        if (!await _context.Users.AnyAsync(u => u.Id == userId)) return null;

        Project projectToDb = new(project, userId);
        
        try
        {
            await _context.Projects.AddAsync(projectToDb);
            await _context.SaveChangesAsync();
            return projectToDb.Id;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid projectId)
    {
        Project project = await _context.Projects.FindAsync(projectId);
        if (project == null) return ServiceStateType.ExperienceNotFound;

        try
        {
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> EditAsync(ProjectDto project, Guid projectId)
    {
        Project proj = await _context.Projects.FindAsync(projectId);
        if (proj == null) return ServiceStateType.ExperienceNotFound;

        proj.Name = project.Name;
        proj.Url = project.Url;
        proj.NativeDesc = project.NativeDesc;
        proj.HasEnglishDesc = project.HasEnglishDesc;
        proj.EnglishDesc = project.EnglishDesc;

        try
        {
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }
}