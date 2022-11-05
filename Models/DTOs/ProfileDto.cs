using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class ProfileDto
{
    public ProfileDto(Profile profile)
    {
        this.Id = profile.Id;
        this.Description = profile.Description;
        this.Phone = profile.Phone;
        this.LocationState = profile.LocationState;
        this.LocationCountry = profile.LocationCountry;
        this.AboutMe = profile.AboutMe;
        this.Config = new ProfileConfigDto(profile.Config);
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

    // Navigations Properties
    public ProfileConfigDto Config { get; set; }
}