using System.ComponentModel.DataAnnotations;

namespace portfolio.Models.DTOs;

public class LoginDto
{
    [Required]
    public string Id { get; set; }


    [Required]
    public string Email { get; set; }


    [Required]
    public string Username { get; set; }
}