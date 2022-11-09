namespace portfolio.Models;

public class Project_Description
{
    public Guid Id { get; set; }
    public Guid ProfileId { get; set; }
    public Guid ProjectId { get; set; }
    public string Description { get; set; }

    // Navigations Properties
    public Profile Profile { get; set; }
    public Project Project { get; set; }
}