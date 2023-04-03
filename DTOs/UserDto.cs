using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class UserDto
{
    public UserDto() { }

    public UserDto(User user)
    {
        this.Name = user.Name;
        this.Email = user.Email;
        this.Username = user.Username;
        this.IsEnglishModeEnabled = user.IsEnglishModeEnabled;
        this.NativeDesc = user.NativeDesc;
        this.HasEnglishDesc = user.HasEnglishDesc;
        this.EnglishDesc = user.EnglishDesc;
        this.LocationCountry = user.LocationCountry;
        this.LocationState = user.LocationState;
        this.NativeAboutMe = user.NativeAboutMe;
        this.HasEnglishAboutMe = user.HasEnglishAboutMe;
        this.EnglishAboutMe = user.EnglishAboutMe;
        SocialMedias = new List<SocialMediaDto>();  // Need to be loaded in service
        Skills = new List<User_SkillDto>();         // Need to be loaded in service
        Experiences = new List<ExperienceDto>();    // Need to be loaded in service
        Educations = new List<EducationDto>();      // Need to be loaded in service
        Projects = new List<ProjectDto>();          // Need to be loaded in service
    }


    [Required]
    [MaxLength(50, ErrorMessage = "Name must be less than 50 characters")]
    public string Name { get; set; }


    [Required]
    [MaxLength(100, ErrorMessage = "Email is too long (Max 100 characters)")]
    [EmailAddress(ErrorMessage = "Invalid Email")]
    public string Email { get; set; }


    [Required]
    [RegularExpression(@"^[a-zA-Z0-9_]+[a-zA-Z0-9._]{4,15}$", ErrorMessage = "Username must be between 4 and 15 characters, and can only contain letters, numbers, underscores and dots.")]
    public string Username { get; set; }


    [Required]
    public bool IsEnglishModeEnabled { get; set; }


    [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters")]
    public string NativeDesc { get; set; }


    [Required]
    public bool HasEnglishDesc { get; set; }


    [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters")]
    public string EnglishDesc { get; set; }


    [MaxLength(50, ErrorMessage = "Country cannot exceed 50 characters")]
    public string LocationCountry { get; set; }


    [MaxLength(50, ErrorMessage = "State cannot exceed 50 characters")]
    public string LocationState { get; set; }


    [MaxLength(500, ErrorMessage = "About Me cannot exceed 500 characters")]
    public string NativeAboutMe { get; set; }


    [Required]
    public bool HasEnglishAboutMe { get; set; }


    [MaxLength(500, ErrorMessage = "About Me cannot exceed 500 characters")]
    public string EnglishAboutMe { get; set; }

    // Navigation Properties
    public virtual ICollection<SocialMediaDto> SocialMedias { get; set; }
    public virtual ICollection<User_SkillDto> Skills { get; set; }
    public virtual ICollection<ExperienceDto> Experiences { get; set; }
    public virtual ICollection<EducationDto> Educations { get; set; }
    public virtual ICollection<ProjectDto> Projects { get; set; }
}