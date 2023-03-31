using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class User_SkillDto
{
    public User_SkillDto() { }

    public User_SkillDto(User_Skill user_Skill)
    {
        this.Id = user_Skill.Id;
        this.Percentage = user_Skill.Percentage;
        this.SkillInfo = new SkillDto(user_Skill.Skill);
    }

    public Guid Id { get; set; }


    [Required]
    [Range(0, 100, ErrorMessage = "Percentage must be between 0 and 100")]
    public int Percentage { get; set; }


    [Required]
    public SkillDto SkillInfo { get; set; }
}