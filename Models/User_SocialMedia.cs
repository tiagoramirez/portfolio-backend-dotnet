using portfolio.Models.DTOs;

namespace portfolio.Models;

public class User_SocialMedia
{
    public User_SocialMedia() { }

    public User_SocialMedia(User_SocialMediaDto socialMedia, Guid userId)
    {
        this.UserId = userId;
        this.SocialMediaId = socialMedia.SocialMediaId;
        this.Url = socialMedia.Url;
    }


    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid SocialMediaId { get; set; }
    public string Url { get; set; }

    // Navigation Properties
    public User User { get; set; }
    public SocialMedia SocialMedia { get; set; }
}