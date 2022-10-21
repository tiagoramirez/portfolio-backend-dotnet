namespace portfolio.Models;

public class Profile
{
    Guid id;
    Guid userId;
    Guid configId;
    string description;
    string phone;
    Location location;
    string aboutMe;
    User user;
    ProfileConfig config;
}