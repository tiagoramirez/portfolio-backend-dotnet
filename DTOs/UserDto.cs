using System.ComponentModel.DataAnnotations;
using portfolio.Models;

namespace portfolio.DTOs;

public class UserDto
{
    [MaxLength(50, ErrorMessage = "Username must be less than 50 characters")]
    public string Name { get; set; }
    [MaxLength(100, ErrorMessage = "Email is too long (Max 100 characters)")]
    [EmailAddress(ErrorMessage = "Invalid Email")]
    public string Email { get; set; }
    [RegularExpression(@"^[a-zA-Z0-9_]+[a-zA-Z0-9._]{4,15}$", ErrorMessage = "Username must be between 4 and 15 characters, and can only contain letters, numbers, underscores and dots.")]
    public string Username { get; set; }

    // Navigations Properties
    public virtual ICollection<Profile> Profiles { get; set; }
    public virtual ICollection<User_SocialMedia> SocialMedias { get; set; }
    public virtual ICollection<User_Skill> Skills { get; set; }
    public virtual ICollection<Experience> Experiences { get; set; }
    public virtual ICollection<Education> Educations { get; set; }
    public virtual ICollection<Project> Projects { get; set; }
}