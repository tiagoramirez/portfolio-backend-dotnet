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

    public async Task<Guid?> CreateAsync(ProjectDto project, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

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

    public async Task<ServiceStateType> DeleteAsync(Guid projectId, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        Project project = await _context.Projects.FindAsync(projectId);
        if (project == null || project.UserId != userId) return ServiceStateType.ProjectNotFound;

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

    public async Task<ServiceStateType> UpdateAsync(ProjectDto project, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        Project proj = await _context.Projects.FindAsync(project.Id);
        if (proj == null || proj.UserId != userId) return ServiceStateType.ProjectNotFound;

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