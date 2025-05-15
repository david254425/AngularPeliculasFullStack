using System.ComponentModel.DataAnnotations;

public class CredencialesUsuarioDTO 
{
    [EmailAddress]
    [Required]
    public required string Email { get; set; }
    [Required]
    public required string Password { get; set; }
}