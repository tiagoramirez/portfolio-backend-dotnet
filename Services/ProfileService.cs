using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;

namespace portfolio.Services;

public interface IProfileService
{
    Task<ServiceStateType> CreateAsync(Guid userId);
    Task<ServiceStateType> UpdateAsync(ProfileDto profile, Guid id);
    Task<ServiceStateType> DeleteAsync(Guid id);
}

public class ProfileService : IProfileService
{
    PortfolioContext _context;

    public ProfileService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(Guid userId)
    {
        if (_context.Profiles.Count(p => p.UserId == userId) == 2) return ServiceStateType.ProfileLimitExceeded;

        Profile profile = new Profile
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            Description = "",
            AboutMe = "",
        };
        try
        {
            await _context.Profiles.AddAsync(profile);
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }

        List<Education> educations = await _context.Educations.Where(e => e.UserId == userId).ToListAsync();

        foreach (Education education in educations)
        {
            string desc = (await _context.EducationDescriptions.FirstOrDefaultAsync(ed => ed.EducationId == education.Id)).Description;
            try
            {
                await _context.EducationDescriptions.AddAsync(new Education_Description
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    EducationId = education.Id,
                    Description = desc
                });
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }

        List<Experience> experiences = await _context.Experiences.Where(e => e.UserId == userId).ToListAsync();

        foreach (Experience experience in experiences)
        {
            string desc = (await _context.ExperienceDescriptions.FirstOrDefaultAsync(ed => ed.ExperienceId == experience.Id)).Description;
            try
            {
                await _context.ExperienceDescriptions.AddAsync(new Experience_Description
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    ExperienceId = experience.Id,
                    Description = desc
                });
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }

        List<Project> projects = await _context.Projects.Where(e => e.UserId == userId).ToListAsync();

        foreach (Project project in projects)
        {
            string desc = (await _context.ProjectDescriptions.FirstOrDefaultAsync(ed => ed.ProjectId == project.Id)).Description;
            try
            {
                await _context.ProjectDescriptions.AddAsync(new Project_Description
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    ProjectId = project.Id,
                    Description = desc
                });
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }

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

    public async Task<ServiceStateType> DeleteAsync(Guid id)
    {
        Profile profile = await _context.Profiles.FindAsync(id);
        if (profile == null) return ServiceStateType.ProfileNotFound;
        if (await _context.Profiles.CountAsync(p => p.UserId == profile.UserId) > 1)
        {
            try
            {
                _context.Profiles.Remove(profile);
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.OneProfileRequired;
    }

    public async Task<ServiceStateType> UpdateAsync(ProfileDto profile, Guid id)
    {
        Profile profileToUpdate = await _context.Profiles.FindAsync(id);
        if (profileToUpdate != null)
        {
            profileToUpdate.Description = profile.Description;
            profileToUpdate.Phone = profile.Phone;
            profileToUpdate.LocationState = profile.LocationState;
            profileToUpdate.LocationCountry = profile.LocationCountry;
            profileToUpdate.AboutMe = profile.AboutMe;
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
        return ServiceStateType.ProfileNotFound;
    }
}