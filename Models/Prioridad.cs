using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("Prioridad")]
    public class Prioridad
    {
        [Key]
        public int IdPrioridad { get; set; }
        [Required]
        public string PrioridadNecesidad { get; set; }
    }
}
