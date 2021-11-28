using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("TipoCalificacionServicio")]
    public class TipoCalificacionServicio
    {
        [Key]
        public int IdTipoCalificacionServicio { get; set; }
        [Required]
        public string TipoCalificacion { get; set; }
    }
}
