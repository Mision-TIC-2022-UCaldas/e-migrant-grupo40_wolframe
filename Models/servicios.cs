using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace proyecto.Models
{
    public class servicios
    {
        [Key]
        public int IdServicios  { get; set; }
        [Required]
        public string ServiciosPrestados  { get; set; }
    }
}
