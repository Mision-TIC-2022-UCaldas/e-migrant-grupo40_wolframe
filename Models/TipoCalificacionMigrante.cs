using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace login2.Models
{
    [Table("TipoCalificacionMigrante")]
    public class TipoCalificacionMigrante
    {
        [Key]
        public int IdTipoCalificacionMigrante { get; set; }
        [Required]
        public string TipoCalificacion { get; set; }
    }
}
