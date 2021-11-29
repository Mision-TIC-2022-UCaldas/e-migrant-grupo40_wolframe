using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("MigranteServicio")]
    public class MigranteServicio
    {
        [Key]
        public int IdMigranteServicio { get; set; }

        [Required]
        public string Detalle { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdServicioEntidad { get; set; }

        [Required]
        public string EstadoServicios { get; set; }
        [Required]
        public string TipoDeUsuario { get; set; }

        [Required]
        public int IdMigrantes { get; set; }

        [ForeignKey("IdMigrantes")]
        public migrantes Migrantes { get; set; }

        [ForeignKey("IdServicioEntidad")]
        public servicios Servicios { get; set; }
    }
}
