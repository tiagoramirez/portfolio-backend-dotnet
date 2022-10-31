using System.Text.Json.Serialization;

namespace portfolio.Models;

public class SocialMedia
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string IconClassName { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public virtual ICollection<User_SocialMedia> User_SocialMedias { get; set; }
}