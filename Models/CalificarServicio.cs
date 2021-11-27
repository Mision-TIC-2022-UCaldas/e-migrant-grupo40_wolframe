using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
    public class CalificarServicio
    {
        [Key]
        public int IdCalificacionServicio  { get; set; }
        [Required]
        public int IdMigranteServicio   { get; set; }
        [ForeignKey("Id")]
        public MigranteServicio MigranteServicio  { get; set; }
        public string calificacion { get; set; }

    }
}
