using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
    public class ServicioEntidad
    {
        [Key]
        public int IdServicioEntidad  { get; set; }
        [Required]
        public string NombreServicio  { get; set; }
        [Required]
        public int NumeroPersonas  { get; set; }
        [Required]
        public DateTime FichaInico  { get; set; }
        [Required]
        public DateTime FichaFinal  { get; set; }
        
        [Required]
        public int IdEstadoServiciosEntidad   { get; set; }
        [ForeignKey("IdEstadoServiciosEntidad ")]
        public EstadoServicioEntidad EstadoServicoEntidad  { get; set; }
        
        [Required]
        public int IdServico  { get; set; }
        [ForeignKey("IdServicios")]
        public Servicios servicios  { get; set; }
        
        [Required]
        public string Nit   { get; set; }
        [ForeignKey("Nit")]
        public Entidad Entidad { get; set;
    }
}
