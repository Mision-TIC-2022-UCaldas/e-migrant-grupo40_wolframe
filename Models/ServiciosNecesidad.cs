using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("ServiciosNecesidad")]
    public class ServiciosNecesidad
    {
        [Key]
        public int IdServiciosNecesidad { get; set; }

        [Required]
        public int IdServicios { get; set; }

        [Required]
        public int IdNecesidad { get; set; }

        [ForeignKey("IdServicios")]
        public servicios servicios { get; set; }

        [ForeignKey("IdNecesidad")]
        public Necesidad Necesidad { get; set; }
    }
}
