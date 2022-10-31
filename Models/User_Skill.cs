using System.Text.Json.Serialization;

namespace portfolio.Models;

public class User_Skill
{
    public Guid Id { get; set; }
    [JsonIgnore]
    public Guid UserId { get; set; }
    public Guid SkillId { get; set; }
    public int Percentage { get; set; }
    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    public Skill Skill { get; set; }
}