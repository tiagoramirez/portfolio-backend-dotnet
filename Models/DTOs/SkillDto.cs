namespace portfolio.Models.DTOs;

public class SkillDto
{
    public SkillDto(Skill skill)
    {
        this.Id = skill.Id;
        this.Name = skill.Name;
        this.Type = skill.Type;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public SkillType Type { get; set; }
}