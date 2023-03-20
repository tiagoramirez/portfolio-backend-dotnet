using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

public class ExperienceService : IExperienceService
{
    PortfolioContext _context;

    public ExperienceService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<Guid?> CreateAsync(ExperienceDto experience, string userId)
    {
        if (!await _context.Users.AnyAsync(u => u.Id == userId)) return null;

        Experience experienceToDb = new Experience(experience, userId);

        try
        {
            await _context.Experiences.AddAsync(experienceToDb);
            await _context.SaveChangesAsync();
            return experienceToDb.Id;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid experienceId)
    {
        Experience experience = await _context.Experiences.FindAsync(experienceId);
        if (experience == null) return ServiceStateType.ExperienceNotFound;

        try
        {
            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> EditAsync(ExperienceDto experience, Guid experienceId)
    {
        Experience exp = await _context.Experiences.FindAsync(experienceId);
        if (exp == null) return ServiceStateType.ExperienceNotFound;

        exp.Position = experience.Position;
        exp.Company = experience.Company;
        exp.Type = experience.Type;
        exp.IsActual = experience.IsActual;
        exp.Start = experience.Start;
        exp.End = experience.End;
        exp.NativeDesc = experience.NativeDesc;
        exp.HasEnglishDesc = experience.HasEnglishDesc;
        exp.EnglishDesc = experience.EnglishDesc;

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