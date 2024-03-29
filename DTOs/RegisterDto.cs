using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class RegisterDto
{
    [Required]
    public string Id { get; set; }


    [Required]
    [MaxLength(100, ErrorMessage = "Email is too long (Max 100 characters)")]
    [EmailAddress(ErrorMessage = "Invalid Email")]
    public string Email { get; set; }


    [Required]
    [RegularExpression(@"^[a-zA-Z0-9_]+[a-zA-Z0-9._]{4,15}$", ErrorMessage = "Username must be between 4 and 15 characters, and can only contain letters, numbers, underscores and dots.")]
    public string Username { get; set; }


    [Required]
    [MaxLength(50, ErrorMessage = "Username must be less than 50 characters")]
    public string Name { get; set; }
}