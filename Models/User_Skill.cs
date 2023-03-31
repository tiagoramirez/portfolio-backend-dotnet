using portfolio.Models.DTOs;

namespace portfolio.Models;

public class User_Skill
{
    public User_Skill() { }

    public User_Skill(User_SkillDto skill, string userId)
    {
        this.Id = new Guid();
        this.UserId = userId;
        this.SkillId = skill.SkillInfo.Id;
        this.Percentage = skill.Percentage;
    }

    public Guid Id { get; set; }
    public string UserId { get; set; }
    public Guid SkillId { get; set; }
    public int Percentage { get; set; }

    // Navigation Properties
    public User User { get; set; }
    public Skill Skill { get; set; }
}