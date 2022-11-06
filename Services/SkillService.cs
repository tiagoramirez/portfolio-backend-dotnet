using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;

namespace portfolio.Services;

public interface ISkillService
{
    IEnumerable<Skill> GetAll();
    Task<ServiceStateType> CreateAsync(User_SkillDto skill, Guid userId);
    Task<ServiceStateType> DeleteAsync(Guid id);
}

public class SkillService : ISkillService
{

    PortfolioContext _context;

    public SkillService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> CreateAsync(User_SkillDto skill, Guid userId)
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

    public IEnumerable<Skill> GetAll()
    {
        return _context.Skills;
    }
}