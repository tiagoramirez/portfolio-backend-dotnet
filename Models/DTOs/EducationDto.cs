using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;
public class EducationDto
{
    public EducationDto() { }

    public EducationDto(Education education)
    {
        this.Id = education.Id;
        this.TitleName = education.TitleName;
        this.Institute = education.Institute;
        this.Type = education.Type;
        this.IsActual = education.IsActual;
        this.Start = education.Start;
        this.End = education.End;
        this.NativeDesc = education.NativeDesc;
        this.HasEnglishDesc = education.HasEnglishDesc;
        this.EnglishDesc = education.EnglishDesc;
    }

    public Guid Id { get; set; }


    [Required]
    [MaxLength(50, ErrorMessage = "Title name cannot exceed 50 characters")]
    public string TitleName { get; set; }


    [Required]
    [MaxLength(50, ErrorMessage = "Institute name cannot exceed 50 characters")]
    public string Institute { get; set; }


    [Required]
    public EducationType Type { get; set; }


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