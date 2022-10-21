namespace portfolio.Models;

public class Role
{
    public Guid Id { get; set; }
    public string RoleName { get; set; }

    // Navigations Properties
    public virtual ICollection<User_Role> User_Roles { get; set; }
}