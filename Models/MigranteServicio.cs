using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
    public class MigranteServicio
 {
        [Key]
        public int IdMigranteServicio  { get; set; }
        [Required]
        public string Detalle  { get; set; }
        [Required]
        public int IdNecesidad  { get; set; }
        [ForeignKey("IdNecesidad")]
        public Necesidad Necesidad  { get; set; }
        [Required]
        public int IdPrioridad { get; set; }
        [ForeignKey("IdPrioridad")]
        public Prioridad prioridad  { get; set; }
        [Required]
        public int IdMigrantes { get; set; }
        [ForeignKey("IdMigrantes")]
        public migrantes Migrantes { get; set; }
    }
}
