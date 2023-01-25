using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class User_SocialMediaDto
{
    public User_SocialMediaDto() { }

    public User_SocialMediaDto(User_SocialMedia user_SocialMedia)
    {
        this.Id = user_SocialMedia.Id;
        this.SocialMediaId = user_SocialMedia.SocialMediaId;
        this.Url = user_SocialMedia.Url;
        this.SocialMediaInfo = new SocialMediaDto(user_SocialMedia.SocialMedia);
    }

    public Guid Id { get; set; }


    public Guid SocialMediaId { get; set; }


    [Required]
    [RegularExpression(@"(https?:\/\/(?:www.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9].[^s]{2,}|www.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9].[^s]{2,}|https?:\/\/(?:www.|(?!www))[a-zA-Z0-9]+.[^s]{2,}|www.[a-zA-Z0-9]+.[^s]{2,})", ErrorMessage = "Please enter a valid URL")]
    public string Url { get; set; }


    // Navigation Properties
    public SocialMediaDto SocialMediaInfo { get; set; }
}