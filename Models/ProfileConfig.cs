namespace portfolio.Models;

public class ProfileConfig
{
    public Guid Id { get; set; }
    public Guid ProfileId { get; set; }
    public bool ShowPhoto { get; set; }
    public bool ShowBanner { get; set; }
    public bool ShowLocation { get; set; }
    public bool ShowPhone { get; set; }

    // Navigations Properties
    public Profile Profile { get; set; }
}