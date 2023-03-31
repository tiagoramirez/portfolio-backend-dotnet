using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class SkillDto
{
    public SkillDto() { }

    public SkillDto(Skill skill)
    {
        this.Id = skill.Id;
        this.Name = skill.Name;
        this.Type = skill.Type;
    }

    public Guid Id { get; set; }


    [Required]
    public string Name { get; set; }


    [Required]
    public SkillType Type { get; set; }
}