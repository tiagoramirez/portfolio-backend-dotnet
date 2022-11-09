using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;

namespace portfolio.Services;

public interface IExperienceService
{
    Task<ServiceStateType> CreateAsync(ExperienceDto experience, Guid userId);
    Task<ServiceStateType> EditAsync(ExperienceDto experience, Guid experienceId, Guid profileId);
    Task<ServiceStateType> DeleteAsync(Guid experienceId);
}

public class ExperienceService : IExperienceService
{
    PortfolioContext _context;

    public ExperienceService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(ExperienceDto experience, Guid userId)
    {
        User user = await _context.Users.Include(p => p.Profiles).FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null) return ServiceStateType.UserNotFound;

        Experience expToDb = new Experience(experience, userId);

        try
        {
            await _context.Experiences.AddAsync(expToDb);
            foreach (Profile profile in user.Profiles)
            {
                Experience_Description expDesc = new Experience_Description
                {
                    ProfileId = profile.Id,
                    ExperienceId = expToDb.Id,
                    Description = experience.Description
                };
                await _context.ExperienceDescriptions.AddAsync(expDesc);
            }
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

    public async Task<ServiceStateType> EditAsync(ExperienceDto experience, Guid experienceId, Guid profileId)
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