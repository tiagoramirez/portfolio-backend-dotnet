namespace portfolio.Models;

public class Skill
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public SkillType Type { get; set; }

    // Navigation Properties
    public virtual ICollection<User_Skill> User_Skills { get; set; }
}

public enum SkillType
{
    FRONTEND, BACKEND, DEVELOPER_TOOL
}