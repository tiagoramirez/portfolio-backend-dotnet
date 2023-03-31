using System.ComponentModel.DataAnnotations;

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


    [Required]
    public SocialMediaName Name { get; set; }


    [Required]
    [RegularExpression(@"/https?:\/\/(www\.)?[-a-zA-Z0-9@:%._+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_+.~#?&//=]*)/", ErrorMessage = "Link not valid or does not contain https://")]
    public string Url { get; set; }
}