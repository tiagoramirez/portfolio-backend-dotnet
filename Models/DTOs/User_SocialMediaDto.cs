using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class User_SocialMediaDto
{
    public User_SocialMediaDto(User_SocialMedia user_SocialMedia)
    {
        this.Id = user_SocialMedia.Id;
        this.Url = user_SocialMedia.Url;
        this.SocialMediaInfo = new SocialMediaDto(user_SocialMedia.SocialMedia);
    }

    public Guid Id { get; set; }


    [Required]
    [DataType(DataType.Url, ErrorMessage = "Please enter a valid URL")]
    public string Url { get; set; }

    // Navigations Properties
    public SocialMediaDto SocialMediaInfo { get; set; }
}