namespace portfolio.Models;

public class Education_Description
{
    public Guid Id { get; set; }
    public Guid ProfileId { get; set; }
    public Guid EducationId { get; set; }
    public string Description { get; set; }

    // Navigations Properties
    public Profile Profile { get; set; }
    public Education Education { get; set; }
}