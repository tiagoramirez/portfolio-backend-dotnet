using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserInfoDto>> GetAllUsersAsync(int page);
    Task<int> GetTotalUsersAsync();
    Task<UserDto> GetUserByUsernameAsync(string username);
    Task<string> GetUsernameByIdEmailAsync(string id, string email);
    Task<bool> IsUsernameAvailableAsync(string username);
    Task<bool> IsEmailAvailableAsync(string email);
    Task<ServiceStateType> UpdateUserAsync(UserDto user, string authorization);
    Task<ServiceStateType> DeleteUserAsync(string authorization);
    Task<ServiceStateType> ToggleEnglishModeAsync(string authorization);
}