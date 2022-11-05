using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class ProfileConfigDto
{
    public ProfileConfigDto(ProfileConfig config)
    {
        this.ShowPhoto = config.ShowPhoto;
        this.ShowBanner = config.ShowBanner;
        this.ShowLocation = config.ShowLocation;
        this.ShowPhone = config.ShowPhone;
    }

    [Required]
    public bool ShowPhoto { get; set; }


    [Required]
    public bool ShowBanner { get; set; }


    [Required]
    public bool ShowLocation { get; set; }


    [Required]
    public bool ShowPhone { get; set; }
}