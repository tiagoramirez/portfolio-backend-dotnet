using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

public class EducationService : IEducationService
{
    PortfolioContext _context;

    public EducationService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<Guid?> CreateAsync(EducationDto education, string userId)
    {
        if (!await _context.Users.AnyAsync(u => u.Id == userId)) return null;

        Education educationToDb = new Education(education, userId);

        try
        {
            await _context.Educations.AddAsync(educationToDb);
            await _context.SaveChangesAsync();
            return educationToDb.Id;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid educationId)
    {
        Education education = await _context.Educations.FindAsync(educationId);
        if (education == null) return ServiceStateType.EducationNotFound;

        try
        {
            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> EditAsync(EducationDto education, Guid educationId)
    {
        Education educ = await _context.Educations.FindAsync(educationId);
        if (educ == null) return ServiceStateType.ExperienceNotFound;

        educ.Type = education.Type;
        educ.Institute = education.Institute;
        educ.TitleName = education.TitleName;
        educ.IsActual = education.IsActual;
        educ.Start = education.Start;
        educ.End = education.End;
        educ.NativeDesc = education.NativeDesc;
        educ.HasEnglishDesc = education.HasEnglishDesc;
        educ.EnglishDesc = education.EnglishDesc;

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