namespace portfolio.Models.DTOs;

public class SocialMediaDto
{
    public SocialMediaDto() { }

    public SocialMediaDto(SocialMedia socialMedia)
    {
        this.Id = socialMedia.Id;
        this.Name = socialMedia.Name;
        this.Url = socialMedia.Url;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}