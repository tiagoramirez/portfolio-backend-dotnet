
using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface ISkillService
{
    IEnumerable<SkillDto> GetAll();
    Task<ServiceStateType> CreateAsync(User_SkillDto skill, string userId);
    Task<ServiceStateType> DeleteAsync(Guid id);
}