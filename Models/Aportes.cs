using System.ComponentModel.DataAnnotations;

namespace AP1_P1_StevenJavier.Models
{
    public class Aportes
    {
        [Key]
        public int AportesId { get; set; }

        [Required(ErrorMessage = "Favor de Ingresar la Fecha.")]
        public DateTime Fecha { get; set; }

        public string? Persona { get; set; }

        [Required(ErrorMessage = "La observacion es requerida")]
        public string? Observacion { get; set; }

        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "El monto no esta dentro del rango requerido (entre 1 y 1,000,000)")]
        public float Monto { get; set; }
    }
}