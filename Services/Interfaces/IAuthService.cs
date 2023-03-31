using portfolio.Helpers;
using portfolio.Models.DTOs;

namespace portfolio.Services.Interfaces;

public interface IAuthService
{
    string GenerateToken(string id, string username);
    Task<bool> isRegisteredAsync(string email, string id);
    Task<ServiceStateType> LoginAync(LoginDto login);
    Task<ServiceStateType> RegisterAsync(RegisterDto register);
}