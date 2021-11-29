using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("EmergenciasMigrantes")]
    public class EmergenciasMigrantes
    {
        [Key]
        public int IdEmergenciasMigrantes { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdMigrante { get; set; }

        [ForeignKey("IdMigrante")]
        public migrantes migrantes { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Tipoemergencia { get; set; }
        [Required]
        public string Ciudad { get; set; }
    }
}