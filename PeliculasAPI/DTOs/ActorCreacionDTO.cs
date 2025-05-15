using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class ActorCreacionDTO
{
    [Required]
    [StringLength(150)]
    public required string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public IFormFile? Foto { get; set; }
}