using portfolio.Auth.DTOs;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Auth.Services;

public interface IRegisterService
{
    Task<ServiceStateType> RegisterAsync(RegisterDto register);
}

public class RegisterService : IRegisterService
{
    PortfolioContext _context;
    IProfileService _profileService;
    IUserService _userService;

    public RegisterService(PortfolioContext context, IProfileService profileService, IUserService userService)
    {
        _context = context;
        _profileService = profileService;
        _userService = userService;
    }

    public async Task<ServiceStateType> RegisterAsync(RegisterDto register)
    {
        if (!_userService.UsernameAvailable(register.Username)) return ServiceStateType.UsernameNotAvailable;
        if (!_userService.EmailAvailable(register.Email)) return ServiceStateType.EmailNotAvailable;
        if (register.Password != register.PasswordConfirmation) return ServiceStateType.PasswordsDoNotMatch;

        User user = new User
        {
            Id = Guid.NewGuid(),
            Name = register.Name,
            Email = register.Email,
            Username = register.Username,
            Password = Encrypt.GetSHA512(register.Password),
            Status = true,
            Created = DateTime.Now,
            Role = "USR"
        };
        try
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return await _profileService.CreateAsync(user.Id);
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }
}