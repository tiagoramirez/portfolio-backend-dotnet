using portfolio.Models.DTOs;

namespace portfolio.Models;

public class Project
{
    public Project() { }

    public Project(ProjectDto project, Guid userId)
    {
        this.Id = Guid.NewGuid();
        this.UserId = userId;
        this.Name = project.Name;
        this.Url = project.Url;
    }

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }

    // Navigations Properties
    public User User { get; set; }
    public ICollection<Project_Description> Descriptions { get; set; }
}