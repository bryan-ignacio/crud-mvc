using System;
using System.ComponentModel.DataAnnotations;

namespace dashboard.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio.")]
    public string? Apellido { get; set; }

    [Required(ErrorMessage = "El celular es obligatorio.")]
    public string? Celular { get; set; }

    [Required(ErrorMessage = "El correo es obligatorio.")]
    public string? Email { get; set; }
}
