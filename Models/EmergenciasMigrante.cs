//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace proyecto.Models
//{
//    [Table("EmergenciasMigrantes")]
//    public class EmergenciasMigrantes
//    {
//        [Key]
//        public int IdEmergenciasMigrantes { get; set; }

//        [Required]
//        public DateTime Fecha { get; set; }

//        [Required]
//        public int IdMigrante { get; set; }

//        [Required]
//        public int IdTipoEmergencia { get; set; }

//        [ForeignKey("IdTipoEmergencia")]
//        public TipoEmergencia TipoEmergencia { get; set; }

//        [ForeignKey("IdMigrante")]
//        public migrantes migrantes { get; set; }
//    }
//}