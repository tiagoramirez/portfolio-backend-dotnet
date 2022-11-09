using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class ProfileDto
{
    public ProfileDto() { }

    public ProfileDto(Profile profile)
    {
        this.Id = profile.Id;
        this.Description = profile.Description;
        this.Phone = profile.Phone;
        this.LocationState = profile.LocationState;
        this.LocationCountry = profile.LocationCountry;
        this.AboutMe = profile.AboutMe;
        this.ShowPhoto = profile.ShowPhoto;
        this.ShowBanner = profile.ShowBanner;
        this.ShowLocation = profile.ShowLocation;
        this.ShowPhone = profile.ShowPhone;
    }

    public Guid Id { get; set; }


    [Required]
    [MaxLength(255, ErrorMessage = "Description must be less than 255 characters")]
    public string Description { get; set; }


    [MaxLength(16, ErrorMessage = "Phone number must be less than 16 characters")]
    public string Phone { get; set; }


    [MaxLength(50, ErrorMessage = "State must be less than 50 characters")]
    public string LocationState { get; set; }


    [MaxLength(50, ErrorMessage = "Country must be less than 50 characters")]
    public string LocationCountry { get; set; }


    [Required]
    [MaxLength(255, ErrorMessage = "About me must be less than 255 characters")]
    public string AboutMe { get; set; }


    [Required]
    public bool ShowPhoto { get; set; }


    [Required]
    public bool ShowBanner { get; set; }


    [Required]
    public bool ShowLocation { get; set; }


    [Required]
    public bool ShowPhone { get; set; }
}