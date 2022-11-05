using portfolio.Models.DTOs;

namespace portfolio.Models;

public class Experience
{
    public Experience() { }

    public Experience(ExperienceDto experience, Guid userId)
    {
        this.UserId = userId;
        this.Position = experience.Position;
        this.Company = experience.Company;
        this.Type = experience.Type;
        this.IsActual = experience.IsActual;
        this.Start = experience.Start;
        this.End = experience.End;
    }

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Position { get; set; }
    public string Company { get; set; }
    public ExperienceType Type { get; set; }
    public bool IsActual { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }

    // Navigations Properties
    public User User { get; set; }
    public ICollection<Experience_Description> Descriptions { get; set; }
}

public enum ExperienceType
{
    FullTime,
    PartTime,
    Freelance,
    Volunteer
}