using System.Text.Json.Serialization;

namespace portfolio.Models;

public class Profile
{
    public Guid Id { get; set; }
    [JsonIgnore]
    public Guid UserId { get; set; }
    [JsonIgnore]
    public Guid ProfileConfigId { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string LocationState { get; set; }
    public string LocationCountry { get; set; }
    public string AboutMe { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    public ProfileConfig Config { get; set; }
    [JsonIgnore]
    public ICollection<Experience_Description> ExperienceDescriptions { get; set; }
    [JsonIgnore]
    public ICollection<Education_Description> EducationDescriptions { get; set; }
    [JsonIgnore]
    public ICollection<Project_Description> ProjectDescriptions { get; set; }
}