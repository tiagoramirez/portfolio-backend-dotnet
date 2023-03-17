using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class UserDto
{
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


    [MaxLength(16, ErrorMessage = "Phone cannot exceed 16 characters")]
    public string Phone { get; set; }


    [MaxLength(50, ErrorMessage = "Country cannot exceed 50 characters")]
    public string LocationCountry { get; set; }


    [MaxLength(50, ErrorMessage = "State cannot exceed 50 characters")]
    public string LocationState { get; set; }


    [MaxLength(255, ErrorMessage = "About Me cannot exceed 255 characters")]
    public string NativeAboutMe { get; set; }


    [Required]
    public bool HasEnglishAboutMe { get; set; }


    [MaxLength(255, ErrorMessage = "About Me cannot exceed 255 characters")]
    public string EnglishAboutMe { get; set; }

    // Navigation Properties
    public virtual ICollection<User_SocialMediaDto> SocialMedias { get; set; }
    public virtual ICollection<User_SkillDto> Skills { get; set; }
    public virtual ICollection<ExperienceDto> Experiences { get; set; }
    public virtual ICollection<EducationDto> Educations { get; set; }
    public virtual ICollection<ProjectDto> Projects { get; set; }
}