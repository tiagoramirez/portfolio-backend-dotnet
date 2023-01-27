using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using portfolio.Models.DTOs;
using portfolio.Helpers;
using portfolio.Models;
using portfolio.Services.Interfaces;

namespace portfolio.Services;

public class UserInfo
{
    public string Name { get; set; }
    public string Username { get; set; }
}

public class UserService : IUserService
{
    PortfolioContext _context;

    public UserService(PortfolioContext context)
    {
        _context = context;
    }

    public async Task<ServiceStateType> DeleteUserAsync(string id)
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

    public async Task<IEnumerable<UserInfo>> GetAllAsync()
    {
        return await _context.Users.Where(u => u.Status).Select(u => new UserInfo { Name = u.Name, Username = u.Username }).ToListAsync();
    }

    public async Task<UserDto> GetByUsernameAsync(string username)
    {
        User user = _context.Users
                    .Include(sm => sm.SocialMedias)
                    .Include(s => s.Skills)
                    .Include(ex => ex.Experiences)
                    .Include(ed => ed.Educations)
                    .Include(pr => pr.Projects)
                    .FirstOrDefault(u => u.Username == username && u.Status);
        if (user == null) return null;

        UserDto userDto = new UserDto()
        {
            Name = user.Name,
            Email = user.Email,
            Username = user.Username,
            IsEnglishModeEnabled = user.IsEnglishModeEnabled,
            NativeDesc = user.NativeDesc,
            HasEnglishDesc = user.HasEnglishDesc,
            EnglishDesc = user.EnglishDesc,
            Phone = user.Phone,
            LocationCountry = user.LocationCountry,
            LocationState = user.LocationState,
            NativeAboutMe = user.NativeAboutMe,
            HasEnglishAboutMe = user.HasEnglishAboutMe,
            EnglishAboutMe = user.EnglishAboutMe,
            SocialMedias = new List<User_SocialMediaDto>(),
            Skills = new List<User_SkillDto>(),
            Experiences = new List<ExperienceDto>(),
            Educations = new List<EducationDto>(),
            Projects = new List<ProjectDto>()
        };

        foreach (var socialMedia in user.SocialMedias)
        {
            socialMedia.SocialMedia = await _context.FindAsync<SocialMedia>(socialMedia.SocialMediaId);
            userDto.SocialMedias.Add(new User_SocialMediaDto(socialMedia));
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

    public async Task<int> GetTotalUsersAsync()
    {
        return await _context.Users.Where(u => u.Status).CountAsync();
    }

    public async Task<string> GetUsernameByIdEmailAsync(string id, string email)
    {
        User user = await _context.Users.Where(u => u.Status && u.Email == email && u.Id == id).FirstOrDefaultAsync();
        return user.Username;
    }

    public bool IsEmailAvailable(string email)
    {
        return !_context.Users.Any(u => u.Email == email);
    }

    public bool IsUsernameAvailable(string username)
    {
        return !_context.Users.Any(u => u.Username == username);
    }

    public async Task<ServiceStateType> ToggleEnglishModeAsync(string id)
    {
        User user = await _context.Users.FindAsync(id);
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

    // Regex passwordRegex = new Regex(@"(?=^.{8,20}$)(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[^A-Za-z0-9]).*");

    public async Task<ServiceStateType> UpdateUserAsync(string id, UserDto user)
    {
        User userToEdit = await _context.Users.FindAsync(id);
        if (userToEdit != null && userToEdit.Status)
        {
            if (!IsEmailAvailable(user.Email) && userToEdit.Email != user.Email) return ServiceStateType.EmailNotAvailable;
            if (!IsUsernameAvailable(user.Username) && userToEdit.Username != user.Username) return ServiceStateType.UsernameNotAvailable;
            userToEdit.Email = user.Email;
            userToEdit.Name = user.Name;
            userToEdit.Username = user.Username;
            userToEdit.NativeDesc = user.NativeDesc;
            userToEdit.HasEnglishDesc = user.HasEnglishDesc;
            userToEdit.EnglishDesc = user.EnglishDesc;
            userToEdit.Phone = user.Phone;
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