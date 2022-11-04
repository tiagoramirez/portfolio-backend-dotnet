using portfolio.Models;

namespace portfolio.DTOs;

public class UserDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }

    // Navigations Properties
    public virtual ICollection<Profile> Profiles { get; set; }
    public virtual ICollection<User_SocialMedia> SocialMedias { get; set; }
    public virtual ICollection<User_Skill> Skills { get; set; }
    public virtual ICollection<Experience> Experiences { get; set; }
    public virtual ICollection<Education> Educations { get; set; }
    public virtual ICollection<Project> Projects { get; set; }
}