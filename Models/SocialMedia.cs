using portfolio.Models.DTOs;

namespace portfolio.Models;

public class SocialMedia
{
    public SocialMedia() { }

    public SocialMedia(SocialMediaDto socialMedia, string userId)
    {
        this.Id = new Guid();
        this.UserId = userId;
        this.Name = socialMedia.Name;
        this.Url = socialMedia.Url;
    }

    public Guid Id { get; set; }
    public string UserId { get; set; }
    public SocialMediaName Name { get; set; }
    public string Url { get; set; }

    // Navigation Properties
    public User User { get; set; }
}

public enum SocialMediaName
{
    FACEBOOK, GITHUB, INSTAGRAM, LINKEDIN, TWITTER, WEBPERSONAL, WHATSAPP, YOUTUBE
}