namespace portfolio.Models;

public class Project
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }

    // Navigations Properties
    public User User { get; set; }
    public ICollection<Project_Description> Descriptions { get; set; }
}