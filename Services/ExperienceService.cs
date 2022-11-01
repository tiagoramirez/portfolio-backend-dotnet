using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IExperienceService
{
    Task<ServiceStateType> CreateAsync(Experience experience, Guid userId);
    Task<ServiceStateType> EditAsync(Experience experience, Guid experienceId, Guid profileId);
    Task<ServiceStateType> DeleteAsync(Guid experienceId);
}

public class ExperienceService : IExperienceService
{
    PortfolioContext _context;

    public ExperienceService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(Experience experience, Guid userId)
    {
        User user = await _context.Users.Include(p => p.Profiles).FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null) return ServiceStateType.UserNotFound;

        experience.Id = Guid.NewGuid();
        experience.UserId = userId;

        Guid firstProfileId = user.Profiles.FirstOrDefault().Id;
        Experience_Description expDesc = new Experience_Description
        {
            Id = Guid.NewGuid(),
            ProfileId = firstProfileId,
            ExperienceId = experience.Id,
            Description = experience.Description
        };

        try
        {
            await _context.Experiences.AddAsync(experience);
            await _context.ExperienceDescriptions.AddAsync(expDesc);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid experienceId)
    {
        Experience exp = await _context.Experiences.FindAsync(experienceId);
        if (exp == null) return ServiceStateType.ExperienceNotFound;

        try
        {
            _context.ExperienceDescriptions.Where(ed => ed.ExperienceId == experienceId).ToList().ForEach(ed => _context.ExperienceDescriptions.Remove(ed));
            _context.Experiences.Remove(exp);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> EditAsync(Experience experience, Guid experienceId, Guid profileId)
    {
        Experience exp = await _context.Experiences.FindAsync(experienceId);
        if (exp == null) return ServiceStateType.ExperienceNotFound;
        exp.Position = experience.Position;
        exp.Company = experience.Company;
        exp.Type = experience.Type;
        exp.IsActual = experience.IsActual;
        exp.Start = experience.Start;
        exp.End = experience.End;
        try
        {
            Experience_Description expDesc = await _context.ExperienceDescriptions.FirstOrDefaultAsync(ed => ed.ExperienceId == experienceId && ed.ProfileId == profileId);
            expDesc.Description = experience.Description;
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }
}