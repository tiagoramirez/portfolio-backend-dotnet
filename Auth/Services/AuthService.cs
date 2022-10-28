using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Auth.Services;

public interface IAuthService
{
    string Login(string username, string password);
    Task<bool> RegisterAsync(User user);
}

public class AuthService : IAuthService
{
    PortfolioContext _context;
    IProfileService _profileService;
    IUserService _userService;

    public AuthService(PortfolioContext context, IProfileService profileService, IUserService userService)
    {
        _context = context;
        _profileService = profileService;
        _userService = userService;
    }

    public string Login(string username, string password)
    {
        User user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == Encrypt.GetSHA512(password));
        if (user != null && user.Status)
        {
            return user.Id.ToString();
        }
        return null;
    }

    public async Task<bool> RegisterAsync(User user)
    {
        if (!_userService.UsernameAvailable(user.Username) || !_userService.EmailAvailable(user.Email)) return false;

        user.Id = Guid.NewGuid();
        user.Password = Encrypt.GetSHA512(user.Password);
        user.Status = true;
        user.Created = DateTime.Now;
        Guid roleId = _context.Roles.FirstOrDefault(r => r.RoleName == "User").Id;
        User_Role user_Role = new User_Role();
        user_Role.RoleId = roleId;
        user_Role.UserId = user.Id;
        try
        {
            await _context.Users.AddAsync(user);
            await _context.User_Roles.AddAsync(user_Role);
            await _context.SaveChangesAsync();
            return await _profileService.CreateAsync(user.Id);
        }
        catch (System.Exception)
        {
            return false;
        }
    }
}