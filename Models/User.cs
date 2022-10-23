namespace portfolio.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
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