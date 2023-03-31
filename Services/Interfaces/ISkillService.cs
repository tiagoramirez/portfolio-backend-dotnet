using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface ISkillService
{
    Task<IEnumerable<SkillDto>> GetAllAsync();
    Task<ServiceStateType> CreateAsync(User_SkillDto skill, string userId);
    Task<ServiceStateType> UpdateAsync(User_SkillDto skill, Guid skillId);
    Task<ServiceStateType> DeleteAsync(Guid id);
}