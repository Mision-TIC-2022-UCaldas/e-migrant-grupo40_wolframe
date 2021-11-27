using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
    public class ServicioMigranteEntidad
    {
        [Key]
        public int IdServiciosMigranteEntidad  { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        
        [Required]
        public int Nit { get; set; }
        [ForeignKey("Nit")]
        public Entidad Entidad { get; set; }
        
        [Required]
        public int IdMigranteServicio  { get; set; }
        [ForeignKey("IdMigranteServicio")]
        public MigranteServicio MigranteServicio  { get; set; }
    }
}
