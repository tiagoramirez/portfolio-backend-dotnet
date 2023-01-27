using portfolio.Models.DTOs;

namespace portfolio.Models;

public class Project
{
    public Project() { }

    public Project(ProjectDto project, string userId)
    {
        this.Id = Guid.NewGuid();
        this.UserId = userId;
        this.Name = project.Name;
        this.Url = project.Url;
        this.NativeDesc = project.NativeDesc;
        this.HasEnglishDesc = project.HasEnglishDesc;
        this.EnglishDesc = project.EnglishDesc;
    }

    public Guid Id { get; set; }
    public string UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string NativeDesc { get; set; }
    public bool HasEnglishDesc { get; set; }
    public string EnglishDesc { get; set; }

    // Navigation Properties
    public User User { get; set; }
}