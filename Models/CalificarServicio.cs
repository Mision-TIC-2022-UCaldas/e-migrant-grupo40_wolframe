using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("CalificarServicio")]
    public class CalificarServicio
    {
        [Key]
        public int IdCalificarServicio { get; set; }

        [Required]
        public string Calificacion { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdMigrarServicios { get; set; }

        [ForeignKey("IdMigrarServicios")]
        public MigranteServicio MigranteServicio { get; set; }
    }
}
