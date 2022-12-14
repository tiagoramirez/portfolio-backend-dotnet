namespace portfolio.Models;

public class Skill
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public SkillType Type { get; set; }

    // Navigations Properties
    public virtual ICollection<User_Skill> User_Skills { get; set; }
}

public enum SkillType
{
    FrontEnd,
    BackEnd,
    DeveloperTool
}