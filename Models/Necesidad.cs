using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("Necesidad")]
    public class Necesidad
    {
        [Key]
        public int IdNecesidad { get; set; }
        [Required]
        public string NombreNecesidad { get; set; }
    }
}
