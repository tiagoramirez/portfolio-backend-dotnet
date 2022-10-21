using System.Text.Json.Serialization;

namespace portfolio.Models;

public class User
{
    Guid id;
    string name;
    string email;
    string username;
    string password;
    string status;
    DateTime created;
    [JsonIgnore]
    public virtual ICollection<Profile> Profiles { get; set; }
}