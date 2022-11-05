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

    // Navigations Properties
    public virtual ICollection<ProfileDto> Profiles { get; set; }
    public virtual ICollection<User_SocialMediaDto> SocialMedias { get; set; }
    public virtual ICollection<User_SkillDto> Skills { get; set; }
    public virtual ICollection<ExperienceDto> Experiences { get; set; }
    public virtual ICollection<EducationDto> Educations { get; set; }
    public virtual ICollection<ProjectDto> Projects { get; set; }
}