using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
    public class EstadoServicioEntidad
    {
        [Key]
        public int IdEstadoServiciosEntidad  { get; set; }
        [Required]
        public string EstadoServiciosEntidad  { get; set; }
    }
}
