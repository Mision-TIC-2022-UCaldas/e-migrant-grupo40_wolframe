using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("EmergenciaMigrantes")]
    public class EmergenciaMigrantes
    {
        [Key]
        public int IdEmergenciaMigrantes { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
        
        [Required]
        public int IdMigrante { get; set; }

        [Required]
        public int IdTipoEmergencia { get; set; }

        [ForeignKey("IdTipoEmergencia")]
        public TipoEmergencia TipoEmergencia { get; set; }

        [ForeignKey("IdMigrante")]
        public Migrantes Migrantes { get; set; }
    }
}
