namespace portfolio.Models;

public class User_SocialMedia
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid SocialMediaId { get; set; }
    public string Url { get; set; }

    // Navigations Properties
    public User User { get; set; }
    public SocialMedia SocialMedia { get; set; }
}