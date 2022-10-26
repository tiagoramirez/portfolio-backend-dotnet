using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IUserService
{
    Task<User> GetUserInfo(string username);
    Task<bool> UpdateName(string name, Guid id);
    Task<bool> UpdateUsername(string username, Guid id);
    Task<bool> UpdatePassword(string password, Guid id);
    Task<bool> UpdateEmail(string email, Guid id);
    Task<bool> Delete(Guid id);
}

public class UserService : IUserService
{
    PortfolioContext _context;

    public UserService(PortfolioContext context)
    {
        _context = context;
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

    public async Task<User> GetUserInfo(string username)
    {
        User user = _context.Users.Include(p => p.Profiles).Include(p => p.Profiles).FirstOrDefault(u => u.Username == username && u.Status);
        user.Password = null;
        foreach (var profile in user.Profiles)
        {
            profile.Config = await _context.FindAsync<ProfileConfig>(profile.ProfileConfigId);
        }
        return user;
    }
}