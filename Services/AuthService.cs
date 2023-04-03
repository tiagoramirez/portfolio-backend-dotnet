using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

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

    public string GenerateToken(string id, string username)
    {
        Claim[] claims = new Claim[]{
            new Claim(ClaimTypes.Sid, id),
            new Claim(ClaimTypes.NameIdentifier, username)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JWT:Key").Value));

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var securityToken = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddHours(24), signingCredentials: credentials);

        string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

        return token;
    }

    public async Task<bool> isRegisteredAsync(string email, string id)
    {
        return await _context.Users.AnyAsync(u => u.Email == email && u.Id == id);
    }

    public async Task<ServiceStateType> LoginAync(LoginDto login)
    {
        if (await _context.Users.AnyAsync(u => u.Username == login.Username && u.Id == login.Id && u.Email == login.Email))
        {
            return ServiceStateType.OK;
        }
        return ServiceStateType.INVALID_CREDENTIALS;
    }

    public async Task<ServiceStateType> RegisterAsync(RegisterDto register)
    {
        if (!await _userService.IsUsernameAvailableAsync(register.Username)) return ServiceStateType.USERNAME_NOT_AVAILABLE;

        User user = new User
        {
            Id = register.Id,
            Name = register.Name,
            Email = register.Email,
            Username = register.Username,
            Status = true,
            Created = DateTime.Now,
            IsEnglishModeEnabled = false,
            NativeDesc = "",
            HasEnglishDesc = false,
            EnglishDesc = "",
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
            return ServiceStateType.OK;
        }
        catch (System.Exception)
        {
            return ServiceStateType.INTERNAL_ERROR;
        }
    }
}