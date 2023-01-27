using Microsoft.EntityFrameworkCore;
using portfolio.Auth.DTOs;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services.Interfaces;

namespace portfolio.Auth.Services;

public interface IAuthService
{
    Task<bool> CheckRegistered(string email, string id);
    Task<string> RegisterAsync(RegisterDto register);
}

public class AuthService : IAuthService
{
    PortfolioContext _context;
    IUserService _userService;

    public AuthService(PortfolioContext context, IUserService userService)
    {
        _context = context;
        _userService = userService;
    }

    public async Task<string> RegisterAsync(RegisterDto register)
    {
        if (!_userService.IsUsernameAvailable(register.Username)) return null;

        User user = new User
        {
            Id = register.Id,
            Name = register.Name,
            Email = register.Email,
            Username = register.Username,
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
            return user.Id.ToString();
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    public async Task<bool> CheckRegistered(string email, string id)
    {
        return await _context.Users.AnyAsync(u => u.Email == email && u.Id == id);
    }
}