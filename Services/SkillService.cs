using Microsoft.EntityFrameworkCore;
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

    public async Task<Guid?> CreateAsync(User_SkillDto skill, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        User_Skill skillToDb = new User_Skill(skill, userId);

        try
        {
            await _context.User_Skills.AddAsync(skillToDb);
            await _context.SaveChangesAsync();
            return skillToDb.Id;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    public async Task<ServiceStateType> DeleteAsync(Guid id, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        User_Skill skill = await _context.User_Skills.FindAsync(id);
        if (skill == null || skill.UserId != userId) return ServiceStateType.SkillNotFound;

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

    public async Task<IEnumerable<SkillDto>> GetAllSkillsAsync()
    {
        List<SkillDto> skills = new List<SkillDto>();
        foreach (Skill skill in await _context.Skills.ToListAsync())
        {
            skills.Add(new SkillDto(skill));
        }
        return skills;
    }

    public async Task<ServiceStateType> UpdateAsync(User_SkillDto skill, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        User_Skill skll = await _context.User_Skills.FindAsync(skill.Id);
        if (skll == null || skll.UserId != userId) return ServiceStateType.SkillNotFound;

        skll.Percentage = skill.Percentage;

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