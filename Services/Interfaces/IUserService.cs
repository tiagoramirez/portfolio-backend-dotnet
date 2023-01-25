
using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserInfo>> GetAllAsync();
    Task<UserDto> GetByUsernameAsync(string username);
    Task<int> GetTotalUsersAsync();
    bool IsUsernameAvailable(string username);
    bool IsEmailAvailable(string email);
    Task<ServiceStateType> UpdateUserAsync(Guid id, UserDto user);
    Task<ServiceStateType> UpdatePasswordAsync(Guid id, string newPass);
    Task<ServiceStateType> DeleteUserAsync(Guid id);
    Task<ServiceStateType> ToggleEnglishModeAsync(Guid id);
}