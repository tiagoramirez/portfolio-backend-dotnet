using System.ComponentModel.DataAnnotations;

namespace portfolio.Auth.DTOs;

public interface LoginDto
{
    [Required]
    public string Id { get; set; }


    [Required]
    public string Username { get; set; }
}