using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("MigranteNecesidad")]
    public class MigranteNecesidad
    {
        [Key]
        public int IdMigranteNecesidad { get; set; }
        public string Detalle { get; set; }

        [Required]
        public int IdNecesidad { get; set; }

        [Required]
        public int IdMigrante { get; set; }

        [Required]
        public int IdPrioridad { get; set; }

        [ForeignKey("IdPrioridad")]
        public Prioridad prioridad { get; set; }

        [ForeignKey("IdMigrante")]
        public Migrantes migrantes { get; set; }

        [ForeignKey("IdNecesidad")]
        public Necesidad Necesidad { get; set; }
    }
}
