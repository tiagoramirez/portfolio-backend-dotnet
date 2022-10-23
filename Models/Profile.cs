using System.Text.Json.Serialization;

namespace portfolio.Models;

public class Profile
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ProfileConfigId { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string LocationState { get; set; }
    public string LocationCountry { get; set; }
    public string AboutMe { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    public ProfileConfig ProfileConfig { get; set; }
    public ICollection<Experience_Description> ExperienceDescriptions { get; set; }
    public ICollection<Education_Description> EducationDescriptions { get; set; }
    public ICollection<Project_Description> ProjectDescriptions { get; set; }
}