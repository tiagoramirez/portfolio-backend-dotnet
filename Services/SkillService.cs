using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

public class SkillService : ISkillService
{

    PortfolioContext _context;

    public SkillService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(User_SkillDto skill, string userId)
    {
        User_Skill skillToDb = new User_Skill(skill, userId);

        try
        {
            _context.User_Skills.Add(skillToDb);
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
        User_Skill skill = await _context.User_Skills.FindAsync(id);
        if (skill == null) return ServiceStateType.SkillNotFound;
        try
        {
            _context.User_Skills.Remove(skill);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public IEnumerable<SkillDto> GetAll()
    {
        List<SkillDto> skills = new List<SkillDto>();
        foreach (Skill skill in _context.Skills)
        {
            skills.Add(new SkillDto(skill));
        }
        return skills;
    }
}