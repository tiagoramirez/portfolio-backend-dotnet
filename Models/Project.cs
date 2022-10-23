using System.Text.Json.Serialization;

namespace portfolio.Models;

public class Project
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    public ICollection<Project_Description> Descriptions { get; set; }
}