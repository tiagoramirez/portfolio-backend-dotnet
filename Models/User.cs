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
    public string Role { get; set; }
    public bool IsEnglishModeEnabled { get; set; }
    public string NativeDesc { get; set; }
    public bool HasEnglishDesc { get; set; }
    public string EnglishDesc { get; set; }
    public string Phone { get; set; }
    public string LocationCountry { get; set; }
    public string LocationState { get; set; }
    public string NativeAboutMe { get; set; }
    public bool HasEnglishAboutMe { get; set; }
    public string EnglishAboutMe { get; set; }


    // Navigation Properties
    public virtual ICollection<User_SocialMedia> SocialMedias { get; set; }
    public virtual ICollection<User_Skill> Skills { get; set; }
    public virtual ICollection<Experience> Experiences { get; set; }
    public virtual ICollection<Education> Educations { get; set; }
    public virtual ICollection<Project> Projects { get; set; }
}