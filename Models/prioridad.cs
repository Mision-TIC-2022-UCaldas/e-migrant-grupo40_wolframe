using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
    public class prioridad
    {
        [Key]
        public int IdPrioridad  { get; set; }
        [Required]
        public string PrioridadNecesidad  { get; set; }
    }
}
