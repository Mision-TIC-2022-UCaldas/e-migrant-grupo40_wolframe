using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("ServicioNecesidad")]
    public class ServicioNecesidad
    {
        [Key]
        public int IdServiciosNecesidad { get; set; }
        
        [Required]
        public int IdServicios { get; set; }

        [Required]
        public int IdNecesidad { get; set; }

        [ForeignKey("IdServicios")]
        public Servicios Servicios { get; set; }
        
        [ForeignKey("IdNecesidad")]
        public Necesidad Necesidad { get; set; }
    }
}
