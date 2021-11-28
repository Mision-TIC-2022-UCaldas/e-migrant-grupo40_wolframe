using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("CalificarMigrante")]
    public class CalificarMigrante
    {
        [Key]
        public int IdCalificarMigrante { get; set; }

        [Required]
        public int IdTipoCalificacionMigrante { get; set; }

        [Required]
        public string NitEntidad { get; set; }

        [Required]
        public int IdMigrante { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [ForeignKey("IdTipoCalificaionMigrante")]
        public TipoCalificacionMigrante TipoCalificacionMigrante { get; set; }

        [ForeignKey("IdEntidad")]
        public Entidad Entidad { get; set; }

        [ForeignKey("IdMigrante")]
        public migrantes migrantes { get; set; }

    }
}