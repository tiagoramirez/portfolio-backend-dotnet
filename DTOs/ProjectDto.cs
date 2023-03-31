using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;
public class ProjectDto
{
    public ProjectDto() { }

    public ProjectDto(Project project)
    {
        this.Id = project.Id;
        this.Name = project.Name;
        this.Url = project.Url;
        this.NativeDesc = project.NativeDesc;
        this.HasEnglishDesc = project.HasEnglishDesc;
        this.EnglishDesc = project.EnglishDesc;
    }

    public Guid Id { get; set; }


    [Required]
    [MaxLength(50, ErrorMessage = "Project name cannot exceed 50 characters")]
    public string Name { get; set; }


    [Required]
    [MaxLength(255, ErrorMessage = "URL cannot exceed 255 characters")]
    [RegularExpression(@"(https?:\/\/(?:www.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9].[^s]{2,}|www.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9].[^s]{2,}|https?:\/\/(?:www.|(?!www))[a-zA-Z0-9]+.[^s]{2,}|www.[a-zA-Z0-9]+.[^s]{2,})", ErrorMessage = "Please enter a valid URL")]
    public string Url { get; set; }


    [Required]
    [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters")]
    public string NativeDesc { get; set; }


    [Required]
    public bool HasEnglishDesc { get; set; }


    [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters")]
    public string EnglishDesc { get; set; }
}