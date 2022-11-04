using System.ComponentModel.DataAnnotations;

namespace portfolio.Auth.DTOs;

public class RegisterDto
{
    [MaxLength(50, ErrorMessage = "Username must be less than 50 characters")]
    public string Name { get; set; }
    [MaxLength(100, ErrorMessage = "Email is too long (Max 100 characters)")]
    [EmailAddress(ErrorMessage = "Invalid Email")]
    public string Email { get; set; }
    [RegularExpression(@"^[a-zA-Z0-9_]+[a-zA-Z0-9._]{4,15}$", ErrorMessage = "Username must be between 4 and 15 characters, and can only contain letters, numbers, underscores and dots.")]
    public string Username { get; set; }
    [RegularExpression(@"(?=^.{8,20}$)(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[^A-Za-z0-9]).*", ErrorMessage = "Password must be between 8 and 20 characters, and must contain at least one uppercase letter, one lowercase letter, one number and one special character.")]
    public string Password { get; set; }
}