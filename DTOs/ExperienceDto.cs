using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;


public class ExperienceDto
{
    public ExperienceDto() { }

    public ExperienceDto(Experience experience)
    {
        this.Id = experience.Id;
        this.Position = experience.Position;
        this.Company = experience.Company;
        this.Type = experience.Type;
        this.IsActual = experience.IsActual;
        this.Start = experience.Start;
        this.End = experience.End;
        this.NativeDesc = experience.NativeDesc;
        this.HasEnglishDesc = experience.HasEnglishDesc;
        this.EnglishDesc = experience.EnglishDesc;
    }

    public Guid Id { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "Position cannot exceed 100 characters")]
    public string Position { get; set; }


    [Required]
    [MaxLength(50, ErrorMessage = "Company cannot exceed 50 characters")]
    public string Company { get; set; }


    [Required]
    public ExperienceType Type { get; set; }


    [Required]
    public bool IsActual { get; set; }


    [Required]
    public DateTime Start { get; set; }


    public DateTime? End { get; set; }


    [Required]
    [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters")]
    public string NativeDesc { get; set; }


    [Required]
    public bool HasEnglishDesc { get; set; }


    [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters")]
    public string EnglishDesc { get; set; }
}