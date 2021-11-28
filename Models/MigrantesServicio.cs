using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace login2.Models
{
    [Table("MigrantesServicio")]
    public class MigrantesServicio
    {
        [Key]
        public int IdMigrantesServicio { get; set; }
       
        [Required]
        public string Detalle { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdServicioEntidad { get; set; }        

        [Required]
        public int IdEstadoServiciosMigrante { get; set; }       

        [Required]
        public int IdMigrantes { get; set; }
        
        [ForeignKey("IdMigrantes")]
        public Migrantes Migrantes { get; set; }

        [ForeignKey("IdEstadoServiciosMigrante")]
        public EstadoServicioMigrante EstadoServicioMigrante { get; set; }

        [ForeignKey("IdServicioEntidad")]
        public ServicioEntidad ServicioEntidad { get; set; }
    }
}
