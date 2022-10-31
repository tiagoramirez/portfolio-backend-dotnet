using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IUserService
{
    Task<IEnumerable<string>> GetAllAsync();
    Task<User> GetByUsernameAsync(string username);
    Task<ServiceStateType> UpdateNameAsync(Guid id, string name);
    Task<ServiceStateType> UpdateUsernameAsync(Guid id, string username);
    Task<ServiceStateType> UpdatePasswordAsync(Guid id, string password);
    Task<ServiceStateType> UpdateEmailAsync(Guid id, string email);
    Task<ServiceStateType> DeleteAsync(Guid id);
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

    public async Task<ServiceStateType> DeleteAsync(Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Status = false;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.UserNotFound;
    }

    public async Task<ServiceStateType> UpdateEmailAsync(Guid id, string email)
    {
        Regex emailRegex = new Regex(@"/^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$/");
        if (!emailRegex.Match(email).Success) return ServiceStateType.InvalidEmail;

        if (!EmailAvailable(email)) return ServiceStateType.EmailNotAvailable;
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Email = email;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.UserNotFound;
            }
        }
        return ServiceStateType.UserNotFound;
    }

    public async Task<ServiceStateType> UpdateNameAsync(Guid id, string name)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Name = name;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.UserNotFound;
    }

    public async Task<ServiceStateType> UpdatePasswordAsync(Guid id, string password)
    {
        Regex passwordRegex = new Regex(@"(?=^.{8,20}$)(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[^A-Za-z0-9]).*");
        if (!passwordRegex.Match(password).Success) return ServiceStateType.InvalidPassword;

        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Password = Encrypt.GetSHA512(password);
            try
            {
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.UserNotFound;
    }

    public async Task<ServiceStateType> UpdateUsernameAsync(Guid id, string username)
    {
        Regex usernameRegex = new Regex(@"^[a-zA-Z0-9_]+[a-zA-Z0-9._]{4,15}$");
        if (!usernameRegex.Match(username).Success) return ServiceStateType.InvalidUsername;
        if (!UsernameAvailable(username)) return ServiceStateType.EmailNotAvailable;
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Username = username;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceStateType.Ok;
            }
            catch (System.Exception)
            {
                return ServiceStateType.InternalError;
            }
        }
        return ServiceStateType.UserNotFound;
    }

    public async Task<User> GetByUsernameAsync(string username)
    {
        User user = _context.Users.Include(p => p.Profiles).Include(sm => sm.SocialMedias).FirstOrDefault(u => u.Username == username && u.Status);
        if (user == null) return null;
        user.Password = null;
        foreach (var profile in user.Profiles)
        {
            profile.Config = await _context.FindAsync<ProfileConfig>(profile.ProfileConfigId);
        }
        foreach (var socialMedia in user.SocialMedias)
        {
            socialMedia.SocialMedia = await _context.FindAsync<SocialMedia>(socialMedia.SocialMediaId);
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

    public async Task<IEnumerable<string>> GetAllAsync()
    {
        List<User> users = await _context.Users.Where(u => u.Status).ToListAsync();
        List<string> usernames = users.Select(u => u.Username).ToList();
        return usernames;
    }
}