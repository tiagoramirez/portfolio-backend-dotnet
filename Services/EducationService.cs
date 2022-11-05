using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;

namespace portfolio.Services;

public interface IEducationService
{
    Task<ServiceStateType> CreateAsync(EducationDto education, Guid userId);
    Task<ServiceStateType> EditAsync(EducationDto education, Guid educationId, Guid profileId);
    Task<ServiceStateType> DeleteAsync(Guid educationId);

}

public class EducationService : IEducationService
{
    PortfolioContext _context;

    public EducationService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(EducationDto education, Guid userId)
    {
        User user = await _context.Users.Include(p => p.Profiles).FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null) return ServiceStateType.UserNotFound;

        Education eduToDb = new Education(education, userId);

        Guid firstProfileId = user.Profiles.FirstOrDefault().Id;
        Education_Description educDesc = new Education_Description
        {
            Id = Guid.NewGuid(),
            ProfileId = firstProfileId,
            EducationId = eduToDb.Id,
            Description = education.Description
        };

        try
        {
            await _context.Educations.AddAsync(eduToDb);
            await _context.EducationDescriptions.AddAsync(educDesc);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid educationId)
    {
        Education education = await _context.Educations.FindAsync(educationId);
        if (education == null) return ServiceStateType.EducationNotFound;

        try
        {
            _context.EducationDescriptions.Where(ed => ed.EducationId == educationId).ToList().ForEach(ed => _context.EducationDescriptions.Remove(ed));
            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<ServiceStateType> EditAsync(EducationDto education, Guid educationId, Guid profileId)
    {
        Education educ = await _context.Educations.FindAsync(educationId);
        if (educ == null) return ServiceStateType.ExperienceNotFound;
        educ.Type = education.Type;
        educ.Institute = education.Institute;
        educ.TitleName = education.TitleName;
        educ.IsActual = education.IsActual;
        educ.Start = education.Start;
        educ.End = education.End;
        try
        {
            Education_Description educDesc = await _context.EducationDescriptions.FirstOrDefaultAsync(ed => ed.EducationId == educationId && ed.ProfileId == profileId);
            educDesc.Description = education.Description;
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }
}