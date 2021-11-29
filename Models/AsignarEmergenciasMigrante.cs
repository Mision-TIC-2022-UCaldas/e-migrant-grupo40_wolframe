using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("AsignarEmergenciasMigrante")]
    public class AsignarEmergenciasMigrante
    {
        [Key]
        public int IdAsignarEmergenciasMigrante { get; set; }
        [Required]
        public int IdEntidadEmergencia { get; set; }
        [Required]
        public int IdEmergenciasMigrantes { get; set; }
        [Required]
        public string Detalle { get; set; }
        [Required]
        public string Estado { get; set; }

        [ForeignKey("IdEmergenciasMigrantes")]
        public EmergenciasMigrantes EmergenciasMigrantes { get; set; }

        [ForeignKey("IdEntidadEmergencia")]
        public EntidadServicioEmergencia EntidadServicioEmergencia { get; set; }

    }
}