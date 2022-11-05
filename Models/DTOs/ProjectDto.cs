using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;
public class ProjectDto
{
    public ProjectDto(Project project)
    {
        this.Id = project.Id;
        this.Name = project.Name;
        this.Url = project.Url;
    }

    public Guid Id { get; set; }


    [Required]
    [MaxLength(50, ErrorMessage = "Project name cannot exceed 50 characters")]
    public string Name { get; set; }


    [Required]
    [MaxLength(255, ErrorMessage = "URL cannot exceed 255 characters")]
    [DataType(DataType.Url, ErrorMessage = "Please enter a valid URL")]
    public string Url { get; set; }


    [Required]
    [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters")]
    public string Description { get; set; }
}