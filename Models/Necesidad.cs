using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    public class Necesidad
    {
        [Key]
        public int IdNecesidad  { get; set; }
        [Required]
        public string NecesidadMigrante  { get; set; }
    }

}
