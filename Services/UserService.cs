using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IUserService
{
    Task<User> GetUserInfoAsync(string username);
    Task<ServiceState> UpdateNameAsync(string name, Guid id);
    Task<ServiceState> UpdateUsernameAsync(string username, Guid id);
    Task<ServiceState> UpdatePasswordAsync(string password, Guid id);
    Task<ServiceState> UpdateEmailAsync(string email, Guid id);
    Task<ServiceState> DeleteAsync(Guid id);
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

    public async Task<ServiceState> DeleteAsync(Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Status = false;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceState.Ok;
            }
            catch (System.Exception)
            {
                return ServiceState.InternalError;
            }
        }
        return ServiceState.UserNotFound;
    }

    public async Task<ServiceState> UpdateEmailAsync(string email, Guid id)
    {
        if (!EmailAvailable(email)) return ServiceState.EmailNotAvailable;
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Email = email;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceState.Ok;
            }
            catch (System.Exception)
            {
                return ServiceState.UserNotFound;
            }
        }
        return ServiceState.UserNotFound;
    }

    public async Task<ServiceState> UpdateNameAsync(string name, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Name = name;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceState.Ok;
            }
            catch (System.Exception)
            {
                return ServiceState.InternalError;
            }
        }
        return ServiceState.UserNotFound;
    }

    public async Task<ServiceState> UpdatePasswordAsync(string password, Guid id)
    {
        Regex passwordRegex = new Regex(@"(?=^.{8,20}$)(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[^A-Za-z0-9]).*");
        if (!passwordRegex.Match(password).Success) return ServiceState.InvalidPassword;

        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Password = Encrypt.GetSHA512(password);
            try
            {
                await _context.SaveChangesAsync();
                return ServiceState.Ok;
            }
            catch (System.Exception)
            {
                return ServiceState.InternalError;
            }
        }
        return ServiceState.UserNotFound;
    }

    public async Task<ServiceState> UpdateUsernameAsync(string username, Guid id)
    {
        Regex usernameRegex = new Regex(@"^[a-zA-Z0-9_]+[a-zA-Z0-9._]{4,15}$");
        if (!usernameRegex.Match(username).Success) return ServiceState.InvalidUsername;
        if (!UsernameAvailable(username)) return ServiceState.EmailNotAvailable;
        User user = await _context.Users.FindAsync(id);
        if (user != null && user.Status)
        {
            user.Username = username;
            try
            {
                await _context.SaveChangesAsync();
                return ServiceState.Ok;
            }
            catch (System.Exception)
            {
                return ServiceState.InternalError;
            }
        }
        return ServiceState.UserNotFound;
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