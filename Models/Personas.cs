using System.ComponentModel.DataAnnotations;

public class Personas
{
    [Key]
    public int PersonaId { get; set; }

    [Required(ErrorMessage = "Favor de Ingresar el nombre")]
    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Favor de Ingresar El Celular")]
    public string? Celular { get; set; }

    public string? Email { get; set; }

    [Required(ErrorMessage = "Favor de Ingresar la direccion")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = "Favor de Ingresar su fecha de nacimiento")]
    public string? FechaNacimiento { get; set; }

}