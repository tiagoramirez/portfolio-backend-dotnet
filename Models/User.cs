using System.ComponentModel.DataAnnotations;

namespace portfolio.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [RegularExpression(@"^[a-zA-Z0-9_]+[a-zA-Z0-9._]{4,15}$", ErrorMessage = "Username must be between 4 and 15 characters, and can only contain letters, numbers, underscores and dots.")]
    public string Username { get; set; }
    [RegularExpression(@"(?=^.{8,20}$)(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[^A-Za-z0-9]).*", ErrorMessage = "Password must be between 8 and 20 characters, and must contain at least one uppercase letter, one lowercase letter, one number and one special character.")]
    public string Password { get; set; }
    public bool Status { get; set; }
    public DateTime Created { get; set; }

    // Navigations Properties
    public virtual ICollection<Profile> Profiles { get; set; }
    public virtual ICollection<User_Role> User_Roles { get; set; }
    public virtual ICollection<User_SocialMedia> User_SocialMedias { get; set; }
    public virtual ICollection<User_Skill> User_Skills { get; set; }
    public virtual ICollection<Experience> Experiences { get; set; }
    public virtual ICollection<Education> Educations { get; set; }
    public virtual ICollection<Project> Projects { get; set; }
}