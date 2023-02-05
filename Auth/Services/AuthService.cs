using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using portfolio.Auth.DTOs;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services.Interfaces;

namespace portfolio.Auth.Services;

public interface IAuthService
{
    Task<bool> CheckRegistered(string email, string id);
    Task<ServiceStateType> RegisterAsync(RegisterDto register);
    string GenerateToken(LoginDto login);
    Task<ServiceStateType> CheckLogin(LoginDto login);
}

public class AuthService : IAuthService
{
    PortfolioContext _context;
    IUserService _userService;
    IConfiguration _config;

    public AuthService(PortfolioContext context, IUserService userService, IConfiguration config)
    {
        _context = context;
        _userService = userService;
        _config = config;
    }

    public async Task<ServiceStateType> RegisterAsync(RegisterDto register)
    {
        if (!_userService.IsUsernameAvailable(register.Username)) return ServiceStateType.EmailNotAvailable;

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
            return ServiceStateType.Ok;
        }
        catch (System.Exception)
        {
            return ServiceStateType.InternalError;
        }
    }

    public async Task<bool> CheckRegistered(string email, string id)
    {
        return await _context.Users.AnyAsync(u => u.Email == email && u.Id == id);
    }

    public string GenerateToken(LoginDto login)
    {
        Claim[] claims = new Claim[]{
            new Claim(ClaimTypes.Sid, login.Id),
            new Claim(ClaimTypes.NameIdentifier, login.Username)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JWT:Key").Value));

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var securityToken = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddHours(2), signingCredentials: credentials);

        string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

        return token;
    }

    public async Task<ServiceStateType> CheckLogin(LoginDto login)
    {
        if (await _context.Users.AnyAsync(u => u.Username == login.Username && u.Id == login.Id))
        {
            return ServiceStateType.Ok;
        }
        return ServiceStateType.InvalidCredentials;
    }
}