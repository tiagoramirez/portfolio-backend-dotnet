namespace portfolio.Models;

public class Project
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}