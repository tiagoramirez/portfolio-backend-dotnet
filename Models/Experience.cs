using System.Text.Json.Serialization;

namespace portfolio.Models;

public class Experience
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Position { get; set; }
    public string Company { get; set; }
    public ExperienceType Type { get; set; }
    public bool IsActual { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    public ICollection<Description> Descriptions { get; set; }
}

public enum ExperienceType
{
    FullTime,
    PartTime,
    Freelance,
    Volunteer
}