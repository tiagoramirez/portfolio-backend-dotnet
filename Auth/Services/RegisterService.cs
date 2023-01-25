using portfolio.Auth.DTOs;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services.Interfaces;

namespace portfolio.Auth.Services;

public interface IRegisterService
{
    Task<ServiceStateType> RegisterAsync(RegisterDto register);
}

public class RegisterService : IRegisterService
{
    PortfolioContext _context;
    IUserService _userService;

    public RegisterService(PortfolioContext context, IUserService userService)
    {
        _context = context;
        _userService = userService;
    }

    public async Task<ServiceStateType> RegisterAsync(RegisterDto register)
    {
        if (!_userService.IsUsernameAvailable(register.Username)) return ServiceStateType.UsernameNotAvailable;
        if (!_userService.IsEmailAvailable(register.Email)) return ServiceStateType.EmailNotAvailable;
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
            Role = "USR",
            IsEnglishModeEnabled = false,
            NativeDesc = "",
            HasEnglishDesc = false,
            EnglishDesc = "",
            Phone = "",
            LocationCountry = "",
            LocationState = "",
            NativeAboutMe = "",
            HasEnglishAboutMe = false,
            EnglishAboutMe = "",
        };
        try
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }
}