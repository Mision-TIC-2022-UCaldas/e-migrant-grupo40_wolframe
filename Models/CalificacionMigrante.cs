using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("CalificacionMigrante")]
    public class CalificacionMigrante
    {
        [Key]
        public int IdCalificacionMigrante { get; set; }

        [Required]
        public int IdTipoCalificaionMigrante { get; set; }

        [Required]
        public string IdEntidad { get; set; }

        [Required]
        public int IdMigrante { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [ForeignKey("IdTipoCalificaionMigrante")]
        public TipoCalificacionMigrante TipoCalificacionMigrante{ get; set; }

        [ForeignKey("IdEntidad")]
        public Entidad Entidad { get; set; }

        [ForeignKey("IdMigrante")]
        public Migrantes Migrantes { get; set; }

    }
}
