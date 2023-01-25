namespace portfolio.Models;

public class SocialMedia
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string IconClassName { get; set; }

    // Navigation Properties
    public virtual ICollection<User_SocialMedia> User_SocialMedias { get; set; }
}