namespace portfolio.Models;

public class Experience_Description
{
    public Guid Id { get; set; }
    public Guid ProfileId { get; set; }
    public Guid ExperienceId { get; set; }
    public string Description { get; set; }

    // Navigations Properties
    public Profile Profile { get; set; }
    public Experience Experience { get; set; }
}