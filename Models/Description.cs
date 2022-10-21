namespace portfolio.Models;

public class Description
{
    public Guid Id { get; set; }
    public Guid ProfileId { get; set; }
    public Guid ExperienceId { get; set; }
    public Guid EducationId { get; set; }
    public Guid ProjectId { get; set; }
    public string Desc { get; set; }

    // Navigations Properties
    public Profile Profile { get; set; }
    public Experience Experience { get; set; }
    public Education Education { get; set; }
    public Project Project { get; set; }
}