using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models

{
    public class ServiciosNecesidad
    {
        [Key]
        public int IdServiciosNecesidad  { get; set; }
        [Required]
        public int IdServicios  { get; set; }
        [ForeignKey("IdServicios")]
        public Servicios Servicios  { get; set; }
        [Required]
        public int IdNecesidad  { get; set; }
        [ForeignKey("IdNecesidad")]
        public Necesidad Necesidad  { get; set; }
    }
}
