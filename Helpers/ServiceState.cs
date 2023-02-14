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
                return "Internal error. Try again later.";
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
            case ServiceStateType.SkillNotFound:
                return "Skill not found";
            case ServiceStateType.ExperienceNotFound:
                return "Experience not found";
            case ServiceStateType.EducationNotFound:
                return "Education not found";
            case ServiceStateType.InvalidCredentials:
                return "Invalid credentials";
            case ServiceStateType.PasswordsDoNotMatch:
                return "Passwords do not match";
            case ServiceStateType.IncorrectEmailIdCombination:
                return "Incorrect Emai and Id combination";
            default:
                return "Unknown error. Try again later.";
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
    SkillNotFound,
    ExperienceNotFound,
    EducationNotFound,
    InvalidCredentials,
    PasswordsDoNotMatch,
    IncorrectEmailIdCombination
}