using System.ComponentModel.DataAnnotations;

public class Genero: IId
{
    public int Id {get; set;}
    [Required(ErrorMessage ="El campo {0} es requerido")]
    [StringLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
    [PrimeraLetraMayuscula]
    public required string Nombre  {get; set; }

}