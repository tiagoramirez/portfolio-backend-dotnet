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

    public async Task<Guid?> CreateAsync(ExperienceDto experience, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

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

    public async Task<ServiceStateType> DeleteAsync(Guid experienceId, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        Experience experience = await _context.Experiences.FindAsync(experienceId);
        if (experience == null || experience.UserId != userId) return ServiceStateType.EXPERIENCE_NOT_FOUND;

        try
        {
            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();
            return ServiceStateType.OK;
        }
        catch (System.Exception)
        {
            return ServiceStateType.INTERNAL_ERROR;
        }
    }

    public async Task<ServiceStateType> UpdateAsync(ExperienceDto experience, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        Experience exp = await _context.Experiences.FindAsync(experience.Id);
        if (exp == null || exp.UserId != userId) return ServiceStateType.EXPERIENCE_NOT_FOUND;

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
            return ServiceStateType.OK;
        }
        catch (System.Exception)
        {
            return ServiceStateType.INTERNAL_ERROR;
        }
    }
}