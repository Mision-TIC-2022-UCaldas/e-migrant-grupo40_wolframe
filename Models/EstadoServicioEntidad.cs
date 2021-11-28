using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("EstadoServicioEntidad")]
    public class EstadoServicioEntidad
    {
        [Key]
        public int IdEstadoServiciosEntidad { get; set; }
        [Required]
        public string EstadoServiciosEntidad { get; set; }
    }
}
