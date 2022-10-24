using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public interface IUserService
{
    string Login(string username, string password);
    Task Register(User user);
    Task Edit(User user, Guid id);
    Task Delete(Guid id);
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

    public async Task Delete(Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            user.Status = false;
            await _context.SaveChangesAsync();
        }
    }

    public async Task Edit(User editedUser, Guid id)
    {
        User user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            user.Name = editedUser.Name;
            user.Email = editedUser.Email;
            user.Username = editedUser.Username;
            user.Password = Encrypt.GetSHA512(editedUser.Password);
            await _context.SaveChangesAsync();
        }
    }

    public bool EmailAvailable(string email)
    {
        return _context.Users.Any(u => u.Email == email);
    }

    public string Login(string username, string password)
    {
        User user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == Encrypt.GetSHA512(password));
        if (user != null)
        {
            return user.Id.ToString();
        }
        return "";
    }

    public async Task Register(User user)
    {
        user.Password = Encrypt.GetSHA512(user.Password);
        user.Status = true;
        user.Created = DateTime.Now;
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public bool UsernameAvailable(string username)
    {
        return _context.Users.Any(u => u.Username == username);
    }
}