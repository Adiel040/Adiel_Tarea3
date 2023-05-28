using System.ComponentModel.DataAnnotations;

namespace Models;
public class Tickets
{
    [Key]
    public int TicketId { get; set; }

    [Required(ErrorMessage = "La fecha es un campo obligatorio. Por favor indique una fecha.")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Range(1, 2000000, ErrorMessage = "El ClienteId es un campo obligatorio. Debe seleccionar un cliente.")]
    public int ClienteId { get; set; }

    [Range(1, 2000000, ErrorMessage = "El SistemaId es un campo obligatorio. Debe seleccionar un sistema.")]
    public int SistemaId { get; set; }

    [Range(1, 2000000, ErrorMessage = "El PrioridadId es un campo obligatorio. Debe seleccionar una prioridad.")]
    public int PrioridadId { get; set; }

    [MinLength(3, ErrorMessage = "El campo SolicitadoPor debe tener al menos {1} caractéres.")]
    [MaxLength(50, ErrorMessage = "El campo SolicitadoPor no debe pasar de {1} caractéres.")]
    public string SolicitadoPor { get; set; } = string.Empty;

    [MinLength(3, ErrorMessage = "El Asunto debe tener al menos {1} caractéres.")]
    [MaxLength(50, ErrorMessage = "El Asunto no debe pasar de {1} caractéres.")]
    public string Asunto { get; set; } = string.Empty;

    [MinLength(3, ErrorMessage = "La descripción debe tener al menos {1} caractéres.")]
    [MaxLength(50, ErrorMessage = "La descripción no debe pasar de {1} caractéres.")]
    public string Descripcion { get; set; } = string.Empty;
}