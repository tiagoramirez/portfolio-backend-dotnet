namespace portfolio.Models;

public class Profile
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string LocationState { get; set; }
    public string LocationCountry { get; set; }
    public string AboutMe { get; set; }
    public bool ShowPhoto { get; set; }
    public bool ShowBanner { get; set; }
    public bool ShowLocation { get; set; }
    public bool ShowPhone { get; set; }

    // Navigations Properties
    public User User { get; set; }
    public ICollection<Experience_Description> ExperienceDescriptions { get; set; }
    public ICollection<Education_Description> EducationDescriptions { get; set; }
    public ICollection<Project_Description> ProjectDescriptions { get; set; }
}