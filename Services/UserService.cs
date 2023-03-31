using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Models.DTOs;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

public class UserService : IUserService
{
    PortfolioContext _context;

    public UserService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> DeleteUserAsync(string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        User user = await _context.Users.FindAsync(userId);
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

    public async Task<IEnumerable<UserInfoDto>> GetAllUsersAsync(int page)
    {
        int totalUsers = await GetTotalUsersAsync();
        int start = page * 10;
        int end = (page + 1) * 10;
        List<UserInfoDto> allUsers = await _context.Users.Where(u => u.Status).Select(u => new UserInfoDto { Name = u.Name, Username = u.Username }).ToListAsync();
        return allUsers.Skip(start).Take(end);
    }

    public async Task<int> GetTotalUsersAsync()
    {
        return await _context.Users.Where(u => u.Status).CountAsync();
    }

    public async Task<UserDto> GetUserByUsernameAsync(string username)
    {
        User user = _context.Users
                    .Include(sm => sm.SocialMedias)
                    .Include(s => s.Skills)
                    .Include(ex => ex.Experiences)
                    .Include(ed => ed.Educations)
                    .Include(pr => pr.Projects)
                    .FirstOrDefault(u => u.Username == username && u.Status);
        if (user == null) return null;

        UserDto userDto = new UserDto(user);

        foreach (var socialMedia in user.SocialMedias)
        {
            userDto.SocialMedias.Add(new SocialMediaDto(socialMedia));
        }
        foreach (var userSkill in user.Skills)
        {
            userSkill.Skill = await _context.FindAsync<Skill>(userSkill.SkillId);
            userDto.Skills.Add(new User_SkillDto(userSkill));
        }
        foreach (var experience in user.Experiences)
        {
            userDto.Experiences.Add(new ExperienceDto(experience));
        }
        foreach (var education in user.Educations)
        {
            userDto.Educations.Add(new EducationDto(education));
        }
        foreach (var project in user.Projects)
        {
            userDto.Projects.Add(new ProjectDto(project));
        }

        return userDto;

    }

    public async Task<string> GetUsernameByIdEmailAsync(string id, string email)
    {
        User user = await _context.Users.Where(u => u.Status && u.Email == email && u.Id == id).FirstOrDefaultAsync();
        return user.Username;
    }

    public async Task<bool> IsEmailAvailableAsync(string email)
    {
        return !(await _context.Users.AnyAsync(u => u.Email == email));
    }

    public async Task<bool> IsUsernameAvailableAsync(string username)
    {
        List<string> usernamesNotAvailable = new List<string> { "page", "count", "available", "username" };
        return !usernamesNotAvailable.Contains(username) && !(await _context.Users.AnyAsync(u => u.Username == username));
    }

    public async Task<ServiceStateType> ToggleEnglishModeAsync(string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        User user = await _context.Users.FindAsync(userId);
        if (user != null && user.Status)
        {
            user.IsEnglishModeEnabled = !user.IsEnglishModeEnabled;
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

    public async Task<ServiceStateType> UpdateUserAsync(UserDto user, string authorization)
    {
        string userId = JwtHelper.GetId(authorization);

        User userToEdit = await _context.Users.FindAsync(userId);
        if (userToEdit != null && userToEdit.Status)
        {
            if (!await IsUsernameAvailableAsync(user.Username) && userToEdit.Username != user.Username) return ServiceStateType.UsernameNotAvailable;
            userToEdit.Name = user.Name;
            userToEdit.Username = user.Username;
            userToEdit.NativeDesc = user.NativeDesc;
            userToEdit.HasEnglishDesc = user.HasEnglishDesc;
            userToEdit.EnglishDesc = user.EnglishDesc;
            userToEdit.LocationCountry = user.LocationCountry;
            userToEdit.LocationState = user.LocationState;
            userToEdit.NativeAboutMe = user.NativeAboutMe;
            userToEdit.HasEnglishAboutMe = user.HasEnglishAboutMe;
            userToEdit.EnglishAboutMe = user.EnglishAboutMe;
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
}