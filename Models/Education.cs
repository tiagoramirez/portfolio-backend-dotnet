using portfolio.Models.DTOs;

namespace portfolio.Models;

public class Education
{
    public Education() { }

    public Education(EducationDto education, Guid userId)
    {
        this.UserId = userId;
        this.TitleName = education.TitleName;
        this.Institute = education.Institute;
        this.Type = education.Type;
        this.IsActual = education.IsActual;
        this.Start = education.Start;
        this.End = education.End;
    }

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string TitleName { get; set; }
    public string Institute { get; set; }
    public EducationType Type { get; set; }
    public bool IsActual { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }

    // Navigations Properties
    public User User { get; set; }
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