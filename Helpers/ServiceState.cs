namespace portfolio.Helpers;

public enum ServiceState
{
    Ok,
    InternalError,
    UsernameNotAvailable,
    EmailNotAvailable,
    UserNotFound,
    InvalidPassword,
    InvalidUsername,
}