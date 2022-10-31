using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace portfolio.Models;

public class User_SocialMedia
{
    public Guid Id { get; set; }
    [JsonIgnore]
    public Guid UserId { get; set; }
    public Guid SocialMediaId { get; set; }
    [DataType(DataType.Url, ErrorMessage = "Please enter a valid URL")]
    public string Url { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    public SocialMedia SocialMedia { get; set; }
}