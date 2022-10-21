using System.Text.Json.Serialization;

namespace portfolio.Models;

public class Profile
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ConfigId { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public Location Location { get; set; }
    public string AboutMe { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    public ProfileConfig Configuration { get; set; }
}