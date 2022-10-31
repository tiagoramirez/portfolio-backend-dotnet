using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface ISkillService
{
    IEnumerable<Skill> GetAll();
    Task<ServiceStateType> CreateAsync(User_Skill skill, Guid userId);
    Task<ServiceStateType> DeleteAsync(Guid id);
}

public class SkillService : ISkillService
{

    PortfolioContext _context;

    public SkillService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(User_Skill skill, Guid userId)
    {
        skill.UserId = userId;
        try
        {
            _context.User_Skills.Add(skill);
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

    public IEnumerable<Skill> GetAll()
    {
        return _context.Skills;
    }
}