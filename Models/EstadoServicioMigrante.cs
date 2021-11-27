using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
   public class EstadoServicioMigrante
    {
        [Key]
        public int IdEstadoServiciosMigrante  { get; set; }
        [Required]
        public string EstadoServiciosMigrante  { get; set; }
    }

}
