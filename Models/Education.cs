using System.Text.Json.Serialization;

namespace portfolio.Models;

public class Education
{
    public Guid Id { get; set; }
    [JsonIgnore]
    public Guid UserId { get; set; }
    public EducationType Type { get; set; }
    public string Institute { get; set; }
    public string TitleName { get; set; }
    public bool IsActual { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public string Description { get; set; }

    // Navigations Properties
    [JsonIgnore]
    public User User { get; set; }
    [JsonIgnore]
    public ICollection<Education_Description> Descriptions { get; set; }
}

public enum EducationType
{
    // Secundaria
    HighSchool,
    // Universidad
    College,
    // Posgrado
    GraduateSchool,
    // Terciario
    TertiaryDegree
}