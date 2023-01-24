using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using portfolio.Models.DTOs;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio.Services;

public class UserInfo
{
    public string Name { get; set; }
    public string Username { get; set; }
}

public interface IUserService
{
    Task<IEnumerable<UserInfo>> GetAllAsync();
    Task<int> GetCount();
    Task<UserDto> GetByUsernameAsync(string username);
    Task<UserDto> LoadDescriptionsAsync(UserDto user, Guid profileId);
    Task<ServiceStateType> UpdateUserAsync(Guid id, UserDto user);
    Task<ServiceStateType> UpdatePasswordAsync(Guid id, string password);
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

    public async Task<ServiceStateType> UpdateUserAsync(Guid id, UserDto user)
    {
        User userToEdit = await _context.Users.FindAsync(id);
        if (userToEdit != null && userToEdit.Status)
        {
            if (!EmailAvailable(user.Email) && userToEdit.Email != user.Email) return ServiceStateType.EmailNotAvailable;
            if (!UsernameAvailable(user.Username) && userToEdit.Username != user.Username) return ServiceStateType.UsernameNotAvailable;
            userToEdit.Email = user.Email;
            userToEdit.Name = user.Name;
            userToEdit.Username = user.Username;
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

    public async Task<UserDto> GetByUsernameAsync(string username)
    {
        User user = _context.Users
                    .Include(p => p.Profiles)
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
            Username = user.Username,
            Email = user.Email,
            Profiles = new List<ProfileDto>(),
            SocialMedias = new List<User_SocialMediaDto>(),
            Skills = new List<User_SkillDto>(),
            Experiences = new List<ExperienceDto>(),
            Educations = new List<EducationDto>(),
            Projects = new List<ProjectDto>()
        };

        foreach (var profile in user.Profiles)
        {
            userDto.Profiles.Add(new ProfileDto(profile));
        }
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

    public bool EmailAvailable(string email)
    {
        return !_context.Users.Any(u => u.Email == email);
    }

    public bool UsernameAvailable(string username)
    {
        return !_context.Users.Any(u => u.Username == username);
    }

    public async Task<IEnumerable<UserInfo>> GetAllAsync()
    {
        return await _context.Users.Where(u => u.Status).Select(u => new UserInfo { Name = u.Name, Username = u.Username }).ToListAsync();
    }

    public async Task<int> GetCount()
    {
        return await _context.Users.Where(u => u.Status).CountAsync();
    }

    public async Task<UserDto> LoadDescriptionsAsync(UserDto user, Guid profileId)
    {
        Guid userId = (await _context.Users.FirstOrDefaultAsync(u => u.Username == user.Username)).Id;

        if (!await _context.Profiles.AnyAsync(p => p.Id == profileId && p.UserId == userId)) return null;

        foreach (var experience in user.Experiences)
        {
            Experience_Description expDesc = await _context.ExperienceDescriptions.Where(ed => ed.ExperienceId == experience.Id && ed.ProfileId == profileId).FirstOrDefaultAsync();
            experience.Description = expDesc.Description;
        }

        foreach (var education in user.Educations)
        {
            Education_Description educDesc = await _context.EducationDescriptions.Where(ed => ed.EducationId == education.Id && ed.ProfileId == profileId).FirstOrDefaultAsync();
            education.Description = educDesc.Description;
        }

        foreach (var project in user.Projects)
        {
            Project_Description projDesct = await _context.ProjectDescriptions.Where(pd => pd.ProjectId == project.Id && pd.ProfileId == profileId).FirstOrDefaultAsync();
            project.Description = projDesct.Description;
        }

        return user;
    }
}