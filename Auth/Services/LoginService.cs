using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using portfolio.Auth.DTOs;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Auth.Services;

public interface ILoginService
{
    Task<ServiceStateType> LoginAsync(LoginDto login);

    Task<string> GenerateToken(LoginDto login);
}

public class LoginService : ILoginService
{
    PortfolioContext _context;

    IConfiguration _config;

    public LoginService(PortfolioContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    public async Task<string> GenerateToken(LoginDto login)
    {
        User user = await _context.Users.FirstOrDefaultAsync(u => u.Username == login.Username);

        Claim[] claims = new Claim[]{
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, login.Username)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JWT:Key").Value));

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var securityToken = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddHours(2), signingCredentials: credentials);

        string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

        return token;
    }

    public async Task<ServiceStateType> LoginAsync(LoginDto login)
    {
        User user = await _context.Users.FirstOrDefaultAsync(u => u.Username == login.Username && u.Password == Encrypt.GetSHA512(login.Password));
        if (user == null) return ServiceStateType.InvalidCredentials;
        return ServiceStateType.Ok;
    }

}