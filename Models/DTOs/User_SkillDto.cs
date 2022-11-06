using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class User_SkillDto
{
    public User_SkillDto() { }

    public User_SkillDto(User_Skill user_Skill)
    {
        this.Id = user_Skill.Id;
        this.SkillId = user_Skill.SkillId;
        this.Percentage = user_Skill.Percentage;
        this.SkillInfo = new SkillDto(user_Skill.Skill);
    }

    public Guid Id { get; set; }


    public Guid SkillId { get; set; }


    [Required]
    [Range(0, 100, ErrorMessage = "Percentage must be between 0 and 100")]
    public int Percentage { get; set; }

    // Navigations Properties
    public SkillDto SkillInfo { get; set; }
}