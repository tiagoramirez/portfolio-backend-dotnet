namespace portfolio.Helpers;

public class ServiceState
{
    public static string GetMessage(ServiceStateType state)
    {
        switch (state)
        {
            case ServiceStateType.OK:
                return "Ok";
            case ServiceStateType.INTERNAL_ERROR:
                return "Internal error. Try again later.";
            case ServiceStateType.USERNAME_NOT_AVAILABLE:
                return "Username not available";
            case ServiceStateType.EMAIL_NOT_AVAILABLE:
                return "Email not available";
            case ServiceStateType.USER_NOT_FOUND:
                return "User not found";
            case ServiceStateType.INVALID_EMAIL:
                return "Invalid email";
            case ServiceStateType.INVALID_PASSWORD:
                return "Invalid password";
            case ServiceStateType.INVALID_USERNAME:
                return "Invalid username";
            case ServiceStateType.SOCIAL_MEDIA_NOT_FOUND:
                return "Social media not found";
            case ServiceStateType.SKILL_NOT_FOUND:
                return "Skill not found";
            case ServiceStateType.EXPERIENCE_NOT_FOUND:
                return "Experience not found";
            case ServiceStateType.EDUCATION_NOT_FOUND:
                return "Education not found";
            case ServiceStateType.PROJECT_NOT_FOUND:
                return "Project not found";
            case ServiceStateType.INVALID_CREDENTIALS:
                return "Invalid credentials";
            case ServiceStateType.PASSWORDS_DO_NOT_MATCH:
                return "Passwords do not match";
            case ServiceStateType.INCORRECT_EMAIL_ID_COMBINATION:
                return "Incorrect Emai and Id combination";
            default:
                return "Unknown error. Try again later.";
        }
    }
}


public enum ServiceStateType
{
    OK,
    INTERNAL_ERROR,
    USERNAME_NOT_AVAILABLE,
    EMAIL_NOT_AVAILABLE,
    USER_NOT_FOUND,
    INVALID_EMAIL,
    INVALID_PASSWORD,
    INVALID_USERNAME,
    SOCIAL_MEDIA_NOT_FOUND,
    SKILL_NOT_FOUND,
    EXPERIENCE_NOT_FOUND,
    EDUCATION_NOT_FOUND,
    PROJECT_NOT_FOUND,
    INVALID_CREDENTIALS,
    PASSWORDS_DO_NOT_MATCH,
    INCORRECT_EMAIL_ID_COMBINATION
}