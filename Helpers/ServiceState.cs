namespace portfolio.Helpers;

public class ServiceState
{
    public static string GetMessage(ServiceStateType state)
    {
        switch (state)
        {
            case ServiceStateType.Ok:
                return "Ok";
            case ServiceStateType.InternalError:
                return "Internal error";
            case ServiceStateType.UsernameNotAvailable:
                return "Username not available";
            case ServiceStateType.EmailNotAvailable:
                return "Email not available";
            case ServiceStateType.UserNotFound:
                return "User not found";
            case ServiceStateType.InvalidEmail:
                return "Invalid email";
            case ServiceStateType.InvalidPassword:
                return "Invalid password";
            case ServiceStateType.InvalidUsername:
                return "Invalid username";
            case ServiceStateType.SocialMediaNotFound:
                return "Social media not found";
            case ServiceStateType.ProfileConfigNotFound:
                return "Profile config not found";
            case ServiceStateType.ProfileNotFound:
                return "Profile not found";
            case ServiceStateType.OneProfileRequired:
                return "User can't have less than one profile";
            default:
                return "Unknown error";
        }
    }
}


public enum ServiceStateType
{
    Ok,
    InternalError,
    UsernameNotAvailable,
    EmailNotAvailable,
    UserNotFound,
    InvalidEmail,
    InvalidPassword,
    InvalidUsername,
    SocialMediaNotFound,
    ProfileConfigNotFound,
    ProfileNotFound,
    OneProfileRequired
}