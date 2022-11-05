namespace portfolio.Models.DTOs;

public class SocialMediaDto
{
    public SocialMediaDto(SocialMedia socialMedia)
    {
        this.Id = socialMedia.Id;
        this.Name = socialMedia.Name;
        this.IconClassName = socialMedia.IconClassName;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string IconClassName { get; set; }
}