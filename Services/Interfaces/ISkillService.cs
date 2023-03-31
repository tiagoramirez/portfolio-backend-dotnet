using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface ISkillService
{
    Task<IEnumerable<SkillDto>> GetAllSkillsAsync();
    Task<Guid?> CreateAsync(User_SkillDto skill, string authorization);
    Task<ServiceStateType> UpdateAsync(User_SkillDto skill, string authorization);
    Task<ServiceStateType> DeleteAsync(Guid id, string authorization);
}