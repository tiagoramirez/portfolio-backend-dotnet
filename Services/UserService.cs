using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IUserService
{
    Task<User> GetUser(string username);
    string Login(string username, string password);
    Task Register(User user);
    Task<bool> UpdateName(string name, Guid id);
    Task<bool> UpdateUsername(string username, Guid id);
    Task<bool> UpdatePassword(string password, Guid id);
    Task<bool> UpdateEmail(string email, Guid id);
    Task<bool> Delete(Guid id);
    bool UsernameAvailable(string username);
    bool EmailAvailable(string email);
}

public class UserService : IUserService
{
    PortfolioContext _context;

    IProfileService _profileService;

    public UserService(PortfolioContext context, IProfileService profileService)
    {
        _context = context;
        _profileService = profileService;
    }

    public async Task<bool> Delete(Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Status = false;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> UpdateEmail(string email, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Email = email;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> UpdateName(string name, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Name = name;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> UpdatePassword(string password, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Password = Encrypt.GetSHA512(password);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> UpdateUsername(string username, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Username = username;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public bool EmailAvailable(string email)
    {
        return !_context.Users.Any(u => u.Email == email);
    }

    public async Task<User> GetUser(string username)
    {
        User user = _context.Users.Include(p => p.Profiles).Include(p => p.Profiles).FirstOrDefault(u => u.Username == username && u.Status);
        user.Password = null;
        foreach (var profile in user.Profiles)
        {
            profile.Config = await _context.FindAsync<ProfileConfig>(profile.ProfileConfigId);
        }
        return user;
    }

    public string Login(string username, string password)
    {
        User user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == Encrypt.GetSHA512(password));
        if (user != null && user.Status)
        {
            return user.Id.ToString();
        }
        return "";
    }

    public async Task Register(User user)
    {
        user.Id = Guid.NewGuid();
        user.Password = Encrypt.GetSHA512(user.Password);
        user.Status = true;
        user.Created = DateTime.Now;
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        await _profileService.Create(user.Id);
    }

    public bool UsernameAvailable(string username)
    {
        return !_context.Users.Any(u => u.Username == username);
    }
}