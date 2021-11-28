using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace login2.Models
{
    [Table("Necesidad")]
    public class Necesidad
    {
        [Key]
        public int IdNecesidad { get; set; }
        [Required]
        public string NecesidadMigrante { get; set; }
    }
}
