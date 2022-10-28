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
        User user = _context.Users.Include(p => p.Profiles).Include(p => p.Profiles).FirstOrDefault(u => u.Username == username && u.Status);
        user.Password = null;
        foreach (var profile in user.Profiles)
        {
            profile.Config = await _context.FindAsync<ProfileConfig>(profile.ProfileConfigId);
        }
        return user;
    }
}