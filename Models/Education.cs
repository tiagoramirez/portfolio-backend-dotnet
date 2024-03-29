using portfolio.Models.DTOs;

namespace portfolio.Models;

public class Education
{
    public Education() { }

    public Education(EducationDto education, string userId)
    {
        this.Id = Guid.NewGuid();
        this.UserId = userId;
        this.TitleName = education.TitleName;
        this.Institute = education.Institute;
        this.Type = education.Type;
        this.IsActual = education.IsActual;
        this.Start = education.Start;
        this.End = education.End;
        this.NativeDesc = education.NativeDesc;
        this.HasEnglishDesc = education.HasEnglishDesc;
        this.EnglishDesc = education.EnglishDesc;
    }

    public Guid Id { get; set; }
    public string UserId { get; set; }
    public string TitleName { get; set; }
    public string Institute { get; set; }
    public EducationType Type { get; set; }
    public bool IsActual { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public string NativeDesc { get; set; }
    public bool HasEnglishDesc { get; set; }
    public string EnglishDesc { get; set; }

    // Navigation Properties
    public User User { get; set; }
}

public enum EducationType
{
    HIGH_SCHOOL, COLLEGE, GRADUATE_SCHOOL, TERTIARY_DEGREE, COURSE
}