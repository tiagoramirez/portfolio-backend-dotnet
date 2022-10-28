using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IUserService
{
    Task<User> GetUserInfoAsync(string username);
    Task<bool> UpdateNameAsync(string name, Guid id);
    Task<bool> UpdateUsernameAsync(string username, Guid id);
    Task<bool> UpdatePasswordAsync(string password, Guid id);
    Task<bool> UpdateEmailAsync(string email, Guid id);
    Task<bool> DeleteAsync(Guid id);
    bool UsernameAvailable(string username);
    bool EmailAvailable(string email);
}

public class UserService : IUserService
{
    PortfolioContext _context;

    public UserService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Status = false;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        return false;
    }

    public async Task<bool> UpdateEmailAsync(string email, Guid id)
    {
        if (!EmailAvailable(email)) return false;
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Email = email;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        return false;
    }

    public async Task<bool> UpdateNameAsync(string name, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Name = name;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        return false;
    }

    public async Task<bool> UpdatePasswordAsync(string password, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Password = Encrypt.GetSHA512(password);
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        return false;
    }

    public async Task<bool> UpdateUsernameAsync(string username, Guid id)
    {
        if (!UsernameAvailable(username)) return false;
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Username = username;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        return false;
    }

    public async Task<User> GetUserInfoAsync(string username)
    {
        User user = _context.Users.Include(p => p.Profiles).FirstOrDefault(u => u.Username == username && u.Status);
        if (user == null) return null;
        user.Password = null;
        foreach (var profile in user.Profiles)
        {
            profile.Config = await _context.FindAsync<ProfileConfig>(profile.ProfileConfigId);
        }
        return user;
    }

    public bool EmailAvailable(string email)
    {
        return !_context.Users.Any(u => u.Email == email);
    }

    public bool UsernameAvailable(string username)
    {
        return !_context.Users.Any(u => u.Username == username);
    }
}