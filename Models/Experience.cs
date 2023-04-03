using portfolio.Models.DTOs;

namespace portfolio.Models;

public class Experience
{
    public Experience() { }

    public Experience(ExperienceDto experience, string userId)
    {
        this.Id = Guid.NewGuid();
        this.UserId = userId;
        this.Position = experience.Position;
        this.Company = experience.Company;
        this.Type = experience.Type;
        this.IsActual = experience.IsActual;
        this.Start = experience.Start;
        this.End = experience.End;
        this.NativeDesc = experience.NativeDesc;
        this.HasEnglishDesc = experience.HasEnglishDesc;
        this.EnglishDesc = experience.EnglishDesc;
    }

    public Guid Id { get; set; }
    public string UserId { get; set; }
    public string Position { get; set; }
    public string Company { get; set; }
    public ExperienceType Type { get; set; }
    public bool IsActual { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public string NativeDesc { get; set; }
    public bool HasEnglishDesc { get; set; }
    public string EnglishDesc { get; set; }

    // Navigation Properties
    public User User { get; set; }
}

public enum ExperienceType
{
    FULLTIME, PARTTIME, FREELANCE, VOLUNTEER
}