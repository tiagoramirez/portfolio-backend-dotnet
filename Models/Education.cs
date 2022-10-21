namespace portfolio.Models;

public class Education
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public EducationType Type { get; set; }
    public string Institute { get; set; }
    public string TitleName { get; set; }
    public bool IsActual { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
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