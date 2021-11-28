using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("CalificacionServicios")]
    public class CalificacionServicios
    {
        [Key]
        public int IdCalificacionServicios { get; set; }
        
        [Required]
        public string Calificacion { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdMigrarServicios { get; set; }

        [ForeignKey("IdMigrarServicios")]
        public MigrantesServicio MigrantesServicio { get; set; }
    }
}
