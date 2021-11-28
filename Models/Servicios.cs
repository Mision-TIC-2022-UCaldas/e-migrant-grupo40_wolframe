using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("Servicios")]
    public class Servicios
    {
        [Key]
        public int IdServicios { get; set; }
        [Required]
        public string ServiciosPrestados { get; set; }
    }
}
