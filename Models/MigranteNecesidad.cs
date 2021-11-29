using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models { 

    [Table("MigranteNecesidad")]
    public class MigranteNecesidad
    {
        [Key]
        public int IdMigranteNecesidad { get; set; }
        [Required]
        public string Necesidad { get; set; }
        [Required]
        public int IdMigrante { get; set; }
        public string Prioridad { get; set; }

        [ForeignKey("IdMigrante")]
        public migrantes Migrantes { get; set; }
        public string Detalle { get; set; }

        public static implicit operator int(MigranteNecesidad v)
        {
            throw new NotImplementedException();
        }
    }
}
