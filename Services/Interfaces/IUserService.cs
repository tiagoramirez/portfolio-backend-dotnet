
using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserInfo>> GetAllAsync();
    Task<UserDto> GetByUsernameAsync(string username);
    Task<int> GetTotalUsersAsync();
    Task<string> GetUsernameByIdEmailAsync(string id, string email);
    Task<bool> IsUsernameAvailable(string username);
    Task<bool> IsEmailAvailable(string email);
    Task<ServiceStateType> UpdateUserAsync(string id, UserDto user);
    Task<ServiceStateType> DeleteUserAsync(string id);
    Task<ServiceStateType> ToggleEnglishModeAsync(string id);
}